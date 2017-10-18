using CCWin;
using com.yhen.downloader.encryptor;
using com.yhen.downloader.module;
using com.yhen.downloader.songFetcher;
using com.yhen.downloader.vo;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KugouFlacMusicDownloader
{
    public partial class MainForm : CCSkinMain
    {
        public MainForm()
        {
            InitializeComponent();
            this.txtSearch.Visible = false;
            this.picSearch.Visible = false;
            this.pnlSearchResult.Visible = false;
            this.txtDownloadDirectory.Text = target;
            this.txtDownloadDirectory.HideSelection = true;
            this.txtDownloadDirectory.SelectedText = "";
            this.txtDownloadDirectory.SelectionLength = 0;
            this.txtDownloadDirectory.SelectionStart = 0;
        }

        private void lblMinimize_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.White;
        }

        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.White;
        }

        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Silver;
        }

        private void lblMinimize_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Silver;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            this.Close();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region 窗体拖动
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void pnlHeadBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void picSearch_Click(object sender, EventArgs e)
        {
            SearchSongAndShow(this.txtSearch.Text.Trim());
        }

        private void lvSongList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (lvSongList.Columns[e.Column].Tag == null)
            {
                lvSongList.Columns[e.Column].Tag = true;
            }
            var tabK = (bool)lvSongList.Columns[e.Column].Tag;
            lvSongList.Columns[e.Column].Tag = !tabK;
            lvSongList.ListViewItemSorter = new ListViewSort(e.Column, lvSongList.Columns[e.Column].Tag);
            //指定排序器并传送列索引与升序降序关键字
            lvSongList.Sort();//对列表进行自定义排序
        }

        private void picSearchBig_Click(object sender, EventArgs e)
        {
            this.txtSearchBig.Visible = false;
            this.picSearchBig.Visible = false;
            this.lblSmile.Visible = false;
            this.txtSearch.Text = this.txtSearchBig.Text.Trim();
            this.txtSearch.HideSelection = true;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            SearchSongAndShow(this.txtSearchBig.Text.Trim());
            this.pnlSearchResult.Visible = true;
            this.txtSearch.Visible = true;
            this.picSearch.Visible = true;
        }

        /// <summary>
        /// 搜索歌曲并展示
        /// </summary>
        /// <param name="songName">搜索的歌曲名称</param>
        private void SearchSongAndShow(string songName)
        {
            this.lblSongName.Text = "“" + songName + "”";
            lvSongList.Items.Clear();
            lvSongList.View = View.Details;
            List<JToken> allSongs = SongFetcher.FetchSongInfo(songName);
            lvSongList.BeginUpdate();   //数据更新，UI暂时挂起，直到EndUpdate绘制控件，可以有效避免闪烁并大大提高加载速度
            allSongs.ForEach(song =>
            {
                KugouMusic kg = JsonConvert.DeserializeObject<KugouMusic>(song.ToString());
                if (kg.sqhash != "")
                {
                    kg.key = MD5Encryptor.Encrypt(kg.sqhash + "kgcloud");
                    JObject flac = SongFetcher.FetchSong(kg);
                    if (flac["status"].ToString() == "1")   //成功获取才添加到显示列表和Result中
                    {
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = kg.filename;
                        lvi.ForeColor = Color.White;
                        lvi.SubItems.Add(kg.filename.Substring(0, kg.filename.IndexOf(" - ")).ToString());
                        lvi.SubItems.Add(flac["extName"].ToString());
                        lvi.SubItems.Add(flac["bitRate"].ToString());
                        TimeSpan ts = new TimeSpan(0, 0, int.Parse(flac["timeLength"].ToString())); //把秒数换算成分钟数
                        lvi.SubItems.Add(ts.Minutes + ":" + ts.Seconds.ToString("00"));
                        lvi.SubItems.Add((double.Parse(flac["fileSize"].ToString()) / (1024 * 1024)).ToString("F2") + "MB");  //将文件大小转换成MB的单位
                        lvi.Tag = flac["url"].ToString().Replace("\\", "");
                        lvi.BackColor = Color.FromArgb(1, 23, 24, 28);
                        lvSongList.Items.Add(lvi);
                    }
                }
            });
            lvSongList.EndUpdate();  //结束数据处理，UI界面一次性绘制
            this.lblSongsCount.Text = lvSongList.Items.Count.ToString();
        }

        #region
        private IntPtr a;
        private ThunderWorkEngine.DownTaskInfo downTaskInfo = new ThunderWorkEngine.DownTaskInfo();
        private string target = Environment.CurrentDirectory + "\\Download\\";

        /// <summary>
        /// 下载歌曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuDownload_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in lvSongList.SelectedItems)
                {
                    this.downloadTimer.Enabled = true;
                    this.downloadTimer.Interval = 500;
                    bool initSuccess = ThunderWorkEngine.XL_Init();

                    if (initSuccess)
                    {
                        ThunderWorkEngine.DownTaskParam downTaskParam = new ThunderWorkEngine.DownTaskParam()
                        {
                            IsResume = 0,
                            szTaskUrl = item.Tag.ToString(),
                            szFilename = item.Text + ".flac",//保存文件名
                            szSavePath = target //下载目录
                        };
                        a = ThunderWorkEngine.XL_CreateTask(downTaskParam);
                        bool startSuccess = ThunderWorkEngine.XL_StartTask(a);
                        MessageBoxEx.Show(startSuccess ? "下载任务已启动！" : "下载任务启动失败！");
                    }
                    else
                    {
                        MessageBoxEx.Show("XL_Init初始化失败！");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBoxEx.Show(ex.Message);
            }
        }

        private void downloadTimer_Tick(object sender, EventArgs e)
        {
            bool taskInfo = ThunderWorkEngine.XL_QueryTaskInfoEx(a, downTaskInfo);
            this.lblDownloadProgress.Text = "下载进度：" + (int)(downTaskInfo.fPercent * 100) + "%";
            this.lblDownloadProgress.Text += string.Format("，速度{0}", (downTaskInfo.nSpeed / 1024.0 / 1024.0 * lvSongList.CheckedItems.Count).ToString("F2") + "MB/s");     //nSpeed只能获取单个文件的下载速度，所以乘以文件数量近似计算出总速度

            if (downTaskInfo.stat == ThunderWorkEngine.DOWN_TASK_STATUS.TSC_COMPLETE)
            {
                this.lblDownloadProgress.Text = "下载进度：" + "下载成功！";
                downloadTimer.Enabled = false;
                ThunderWorkEngine.XL_StartTask(a);
                ThunderWorkEngine.XL_UnInit();
            }
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.txtDownloadDirectory.Text = ofd.SelectedPath + "\\";
                target = this.txtDownloadDirectory.Text;
            }
        }
        #endregion

        private void MainForm_Activated(object sender, EventArgs e)
        {
            this.txtSearchBig.Focus();
        }
    }
}
