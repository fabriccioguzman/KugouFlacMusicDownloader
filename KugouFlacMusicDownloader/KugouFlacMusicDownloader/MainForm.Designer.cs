namespace KugouFlacMusicDownloader
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlHeadBar = new CCWin.SkinControl.SkinPanel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlBottomBar = new CCWin.SkinControl.SkinPanel();
            this.txtSearchBig = new System.Windows.Forms.TextBox();
            this.picSearchBig = new System.Windows.Forms.PictureBox();
            this.rightClickMenus = new CCWin.SkinControl.SkinContextMenuStrip();
            this.menuDownload = new System.Windows.Forms.ToolStripMenuItem();
            this.downloadTimer = new System.Windows.Forms.Timer(this.components);
            this.lblDownloadSetting = new CCWin.SkinControl.SkinLabel();
            this.txtDownloadDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowser = new CCWin.SkinControl.SkinButton();
            this.lblDownloadProgress = new CCWin.SkinControl.SkinLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lblSmile = new CCWin.SkinControl.SkinLabel();
            this.pnlSearchResult = new CCWin.SkinControl.SkinPanel();
            this.lblSongsCount = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.lblSongName = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.lvSongList = new CCWin.SkinControl.SkinListView();
            this.songName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.songSinger = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.songFormat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.songBitRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.songDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.songSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlHeadBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.pnlBottomBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchBig)).BeginInit();
            this.rightClickMenus.SuspendLayout();
            this.pnlSearchResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeadBar
            // 
            this.pnlHeadBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeadBar.Controls.Add(this.skinLabel2);
            this.pnlHeadBar.Controls.Add(this.picSearch);
            this.pnlHeadBar.Controls.Add(this.lblMinimize);
            this.pnlHeadBar.Controls.Add(this.lblClose);
            this.pnlHeadBar.Controls.Add(this.txtSearch);
            this.pnlHeadBar.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pnlHeadBar.DownBack = null;
            this.pnlHeadBar.ForeColor = System.Drawing.Color.White;
            this.pnlHeadBar.Location = new System.Drawing.Point(7, 3);
            this.pnlHeadBar.MouseBack = null;
            this.pnlHeadBar.Name = "pnlHeadBar";
            this.pnlHeadBar.NormlBack = null;
            this.pnlHeadBar.Size = new System.Drawing.Size(1008, 50);
            this.pnlHeadBar.TabIndex = 1;
            this.pnlHeadBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlHeadBar_MouseDown);
            // 
            // skinLabel2
            // 
            this.skinLabel2.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.skinLabel2.ForeColor = System.Drawing.Color.White;
            this.skinLabel2.Location = new System.Drawing.Point(12, 9);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(89, 31);
            this.skinLabel2.TabIndex = 5;
            this.skinLabel2.Text = "Kugoo";
            this.skinLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picSearch
            // 
            this.picSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.picSearch.BackgroundImage = global::KugouFlacMusicDownloader.Properties.Resources.icon_search_l;
            this.picSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSearch.ErrorImage = null;
            this.picSearch.InitialImage = null;
            this.picSearch.Location = new System.Drawing.Point(393, 17);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(33, 18);
            this.picSearch.TabIndex = 3;
            this.picSearch.TabStop = false;
            this.toolTip.SetToolTip(this.picSearch, "搜索");
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblMinimize.ForeColor = System.Drawing.Color.Silver;
            this.lblMinimize.Location = new System.Drawing.Point(952, 14);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(19, 20);
            this.lblMinimize.TabIndex = 2;
            this.lblMinimize.Text = "─";
            this.toolTip.SetToolTip(this.lblMinimize, "最小化");
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            this.lblMinimize.MouseEnter += new System.EventHandler(this.lblMinimize_MouseEnter);
            this.lblMinimize.MouseLeave += new System.EventHandler(this.lblMinimize_MouseLeave);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblClose.ForeColor = System.Drawing.Color.Silver;
            this.lblClose.Location = new System.Drawing.Point(983, 14);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(18, 20);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "X";
            this.toolTip.SetToolTip(this.lblClose, "退出程序");
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseEnter += new System.EventHandler(this.lblClose_MouseEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.lblClose_MouseLeave);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(208, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 23);
            this.txtSearch.TabIndex = 0;
            // 
            // pnlBottomBar
            // 
            this.pnlBottomBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlBottomBar.Controls.Add(this.lblDownloadProgress);
            this.pnlBottomBar.Controls.Add(this.btnBrowser);
            this.pnlBottomBar.Controls.Add(this.txtDownloadDirectory);
            this.pnlBottomBar.Controls.Add(this.lblDownloadSetting);
            this.pnlBottomBar.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pnlBottomBar.DownBack = null;
            this.pnlBottomBar.Location = new System.Drawing.Point(7, 538);
            this.pnlBottomBar.MouseBack = null;
            this.pnlBottomBar.Name = "pnlBottomBar";
            this.pnlBottomBar.NormlBack = null;
            this.pnlBottomBar.Size = new System.Drawing.Size(1008, 129);
            this.pnlBottomBar.TabIndex = 2;
            // 
            // txtSearchBig
            // 
            this.txtSearchBig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.txtSearchBig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchBig.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.txtSearchBig.ForeColor = System.Drawing.Color.White;
            this.txtSearchBig.Location = new System.Drawing.Point(324, 324);
            this.txtSearchBig.Name = "txtSearchBig";
            this.txtSearchBig.Size = new System.Drawing.Size(320, 39);
            this.txtSearchBig.TabIndex = 4;
            this.toolTip.SetToolTip(this.txtSearchBig, "输入以搜索歌曲、歌手");
            // 
            // picSearchBig
            // 
            this.picSearchBig.BackColor = System.Drawing.Color.Transparent;
            this.picSearchBig.BackgroundImage = global::KugouFlacMusicDownloader.Properties.Resources.icon_search_l;
            this.picSearchBig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSearchBig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSearchBig.ErrorImage = null;
            this.picSearchBig.InitialImage = null;
            this.picSearchBig.Location = new System.Drawing.Point(648, 324);
            this.picSearchBig.Name = "picSearchBig";
            this.picSearchBig.Size = new System.Drawing.Size(49, 39);
            this.picSearchBig.TabIndex = 5;
            this.picSearchBig.TabStop = false;
            this.toolTip.SetToolTip(this.picSearchBig, "搜索");
            this.picSearchBig.Click += new System.EventHandler(this.picSearchBig_Click);
            // 
            // rightClickMenus
            // 
            this.rightClickMenus.Arrow = System.Drawing.Color.Black;
            this.rightClickMenus.Back = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.rightClickMenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.rightClickMenus.BackRadius = 4;
            this.rightClickMenus.Base = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.rightClickMenus.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.rightClickMenus.Fore = System.Drawing.Color.White;
            this.rightClickMenus.HoverFore = System.Drawing.Color.White;
            this.rightClickMenus.ItemAnamorphosis = false;
            this.rightClickMenus.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.rightClickMenus.ItemBorderShow = true;
            this.rightClickMenus.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.rightClickMenus.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(58)))), ((int)(((byte)(61)))));
            this.rightClickMenus.ItemRadius = 4;
            this.rightClickMenus.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.rightClickMenus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDownload});
            this.rightClickMenus.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.rightClickMenus.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.rightClickMenus.Name = "rightClickMenus";
            this.rightClickMenus.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.rightClickMenus.ShowItemToolTips = false;
            this.rightClickMenus.Size = new System.Drawing.Size(155, 26);
            this.rightClickMenus.SkinAllColor = true;
            this.rightClickMenus.Text = "右键菜单";
            this.rightClickMenus.TitleAnamorphosis = true;
            this.rightClickMenus.TitleColor = System.Drawing.Color.Transparent;
            this.rightClickMenus.TitleRadius = 4;
            this.rightClickMenus.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // menuDownload
            // 
            this.menuDownload.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.menuDownload.Name = "menuDownload";
            this.menuDownload.ShortcutKeyDisplayString = "Ctrl + D";
            this.menuDownload.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.menuDownload.Size = new System.Drawing.Size(154, 22);
            this.menuDownload.Text = "下载";
            this.menuDownload.Click += new System.EventHandler(this.menuDownload_Click);
            // 
            // downloadTimer
            // 
            this.downloadTimer.Interval = 500;
            this.downloadTimer.Tick += new System.EventHandler(this.downloadTimer_Tick);
            // 
            // lblDownloadSetting
            // 
            this.lblDownloadSetting.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.lblDownloadSetting.AutoSize = true;
            this.lblDownloadSetting.BackColor = System.Drawing.Color.Transparent;
            this.lblDownloadSetting.BorderColor = System.Drawing.Color.White;
            this.lblDownloadSetting.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblDownloadSetting.ForeColor = System.Drawing.Color.White;
            this.lblDownloadSetting.Location = new System.Drawing.Point(15, 10);
            this.lblDownloadSetting.Name = "lblDownloadSetting";
            this.lblDownloadSetting.Size = new System.Drawing.Size(65, 20);
            this.lblDownloadSetting.TabIndex = 11;
            this.lblDownloadSetting.Text = "下载设置";
            this.lblDownloadSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDownloadDirectory
            // 
            this.txtDownloadDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.txtDownloadDirectory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDownloadDirectory.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.txtDownloadDirectory.ForeColor = System.Drawing.Color.White;
            this.txtDownloadDirectory.Location = new System.Drawing.Point(50, 51);
            this.txtDownloadDirectory.Name = "txtDownloadDirectory";
            this.txtDownloadDirectory.Size = new System.Drawing.Size(320, 24);
            this.txtDownloadDirectory.TabIndex = 12;
            // 
            // btnBrowser
            // 
            this.btnBrowser.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowser.BaseColor = System.Drawing.Color.Transparent;
            this.btnBrowser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnBrowser.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnBrowser.DownBack = null;
            this.btnBrowser.DownBaseColor = System.Drawing.Color.Transparent;
            this.btnBrowser.FadeGlow = false;
            this.btnBrowser.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowser.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnBrowser.ForeColor = System.Drawing.Color.White;
            this.btnBrowser.GlowColor = System.Drawing.Color.Transparent;
            this.btnBrowser.InheritColor = true;
            this.btnBrowser.InnerBorderColor = System.Drawing.Color.Silver;
            this.btnBrowser.IsDrawGlass = false;
            this.btnBrowser.Location = new System.Drawing.Point(382, 47);
            this.btnBrowser.MouseBack = null;
            this.btnBrowser.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.NormlBack = null;
            this.btnBrowser.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.btnBrowser.Size = new System.Drawing.Size(75, 33);
            this.btnBrowser.TabIndex = 13;
            this.btnBrowser.Text = "浏览";
            this.btnBrowser.UseVisualStyleBackColor = false;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // lblDownloadProgress
            // 
            this.lblDownloadProgress.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.lblDownloadProgress.AutoSize = true;
            this.lblDownloadProgress.BackColor = System.Drawing.Color.Transparent;
            this.lblDownloadProgress.BorderColor = System.Drawing.Color.White;
            this.lblDownloadProgress.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblDownloadProgress.ForeColor = System.Drawing.Color.White;
            this.lblDownloadProgress.Location = new System.Drawing.Point(20, 101);
            this.lblDownloadProgress.Name = "lblDownloadProgress";
            this.lblDownloadProgress.Size = new System.Drawing.Size(56, 17);
            this.lblDownloadProgress.TabIndex = 14;
            this.lblDownloadProgress.Text = "准备就绪";
            this.lblDownloadProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolTip
            // 
            this.toolTip.BackColor = System.Drawing.Color.Transparent;
            this.toolTip.ForeColor = System.Drawing.Color.White;
            // 
            // lblSmile
            // 
            this.lblSmile.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.lblSmile.AutoSize = true;
            this.lblSmile.BackColor = System.Drawing.Color.Transparent;
            this.lblSmile.BorderColor = System.Drawing.Color.White;
            this.lblSmile.Font = new System.Drawing.Font("微软雅黑", 22F);
            this.lblSmile.ForeColor = System.Drawing.Color.White;
            this.lblSmile.Location = new System.Drawing.Point(474, 265);
            this.lblSmile.Name = "lblSmile";
            this.lblSmile.Size = new System.Drawing.Size(74, 39);
            this.lblSmile.TabIndex = 17;
            this.lblSmile.Text = "^_^";
            this.lblSmile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlSearchResult
            // 
            this.pnlSearchResult.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearchResult.Controls.Add(this.lblSongsCount);
            this.pnlSearchResult.Controls.Add(this.skinLabel4);
            this.pnlSearchResult.Controls.Add(this.skinLabel3);
            this.pnlSearchResult.Controls.Add(this.lblSongName);
            this.pnlSearchResult.Controls.Add(this.skinLabel1);
            this.pnlSearchResult.Controls.Add(this.lvSongList);
            this.pnlSearchResult.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pnlSearchResult.DownBack = null;
            this.pnlSearchResult.Location = new System.Drawing.Point(7, 58);
            this.pnlSearchResult.MouseBack = null;
            this.pnlSearchResult.Name = "pnlSearchResult";
            this.pnlSearchResult.NormlBack = null;
            this.pnlSearchResult.Size = new System.Drawing.Size(1008, 473);
            this.pnlSearchResult.TabIndex = 18;
            // 
            // lblSongsCount
            // 
            this.lblSongsCount.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.lblSongsCount.AutoSize = true;
            this.lblSongsCount.BackColor = System.Drawing.Color.Transparent;
            this.lblSongsCount.BorderColor = System.Drawing.Color.White;
            this.lblSongsCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSongsCount.ForeColor = System.Drawing.Color.White;
            this.lblSongsCount.Location = new System.Drawing.Point(187, 22);
            this.lblSongsCount.Name = "lblSongsCount";
            this.lblSongsCount.Size = new System.Drawing.Size(15, 17);
            this.lblSongsCount.TabIndex = 14;
            this.lblSongsCount.Text = "0";
            this.lblSongsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // skinLabel4
            // 
            this.skinLabel4.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.Color.White;
            this.skinLabel4.Location = new System.Drawing.Point(207, 22);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(44, 17);
            this.skinLabel4.TabIndex = 13;
            this.skinLabel4.Text = "首单曲";
            this.skinLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // skinLabel3
            // 
            this.skinLabel3.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.ForeColor = System.Drawing.Color.White;
            this.skinLabel3.Location = new System.Drawing.Point(137, 22);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(44, 17);
            this.skinLabel3.TabIndex = 12;
            this.skinLabel3.Text = "，找到";
            this.skinLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSongName
            // 
            this.lblSongName.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.lblSongName.AutoSize = true;
            this.lblSongName.BackColor = System.Drawing.Color.Transparent;
            this.lblSongName.BorderColor = System.Drawing.Color.White;
            this.lblSongName.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSongName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblSongName.Location = new System.Drawing.Point(47, 22);
            this.lblSongName.Name = "lblSongName";
            this.lblSongName.Size = new System.Drawing.Size(84, 17);
            this.lblSongName.TabIndex = 11;
            this.lblSongName.Text = "“ 歌曲名称“";
            this.lblSongName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // skinLabel1
            // 
            this.skinLabel1.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.White;
            this.skinLabel1.Location = new System.Drawing.Point(15, 22);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 10;
            this.skinLabel1.Text = "搜索";
            this.skinLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lvSongList
            // 
            this.lvSongList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.lvSongList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(43)))));
            this.lvSongList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSongList.CheckBoxes = true;
            this.lvSongList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.songName,
            this.songSinger,
            this.songFormat,
            this.songBitRate,
            this.songDuration,
            this.songSize});
            this.lvSongList.ContextMenuStrip = this.rightClickMenus;
            this.lvSongList.ForeColor = System.Drawing.Color.White;
            this.lvSongList.FullRowSelect = true;
            this.lvSongList.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(131)))), ((int)(((byte)(133)))));
            this.lvSongList.Location = new System.Drawing.Point(0, 57);
            this.lvSongList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvSongList.Name = "lvSongList";
            this.lvSongList.OwnerDraw = true;
            this.lvSongList.RowBackColor1 = System.Drawing.Color.Empty;
            this.lvSongList.RowBackColor2 = System.Drawing.Color.Empty;
            this.lvSongList.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(50)))));
            this.lvSongList.ShowGroups = false;
            this.lvSongList.Size = new System.Drawing.Size(1008, 410);
            this.lvSongList.TabIndex = 9;
            this.lvSongList.UseCompatibleStateImageBehavior = false;
            this.lvSongList.View = System.Windows.Forms.View.Details;
            // 
            // songName
            // 
            this.songName.Text = "音乐标题";
            this.songName.Width = 340;
            // 
            // songSinger
            // 
            this.songSinger.Text = "歌手";
            this.songSinger.Width = 250;
            // 
            // songFormat
            // 
            this.songFormat.Text = "格式";
            this.songFormat.Width = 100;
            // 
            // songBitRate
            // 
            this.songBitRate.Text = "比特率";
            this.songBitRate.Width = 100;
            // 
            // songDuration
            // 
            this.songDuration.Text = "时长";
            this.songDuration.Width = 118;
            // 
            // songSize
            // 
            this.songSize.Text = "文件大小";
            this.songSize.Width = 100;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(28)))));
            this.BackShade = false;
            this.CanResize = false;
            this.CaptionHeight = 42;
            this.ClientSize = new System.Drawing.Size(1022, 670);
            this.ControlBox = false;
            this.Controls.Add(this.lblSmile);
            this.Controls.Add(this.picSearchBig);
            this.Controls.Add(this.txtSearchBig);
            this.Controls.Add(this.pnlBottomBar);
            this.Controls.Add(this.pnlHeadBar);
            this.Controls.Add(this.pnlSearchResult);
            this.EffectCaption = CCWin.TitleType.None;
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Shadow = false;
            this.ShowDrawIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "酷狗无损音乐Flac下载器 - Yhen";
            this.TitleColor = System.Drawing.Color.White;
            this.TitleOffset = new System.Drawing.Point(6, 0);
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.pnlHeadBar.ResumeLayout(false);
            this.pnlHeadBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.pnlBottomBar.ResumeLayout(false);
            this.pnlBottomBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchBig)).EndInit();
            this.rightClickMenus.ResumeLayout(false);
            this.pnlSearchResult.ResumeLayout(false);
            this.pnlSearchResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinPanel pnlHeadBar;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.PictureBox picSearch;
        private CCWin.SkinControl.SkinPanel pnlBottomBar;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private System.Windows.Forms.PictureBox picSearchBig;
        private System.Windows.Forms.TextBox txtSearchBig;
        private CCWin.SkinControl.SkinContextMenuStrip rightClickMenus;
        private System.Windows.Forms.ToolStripMenuItem menuDownload;
        private System.Windows.Forms.Timer downloadTimer;
        private CCWin.SkinControl.SkinLabel lblDownloadSetting;
        private System.Windows.Forms.TextBox txtDownloadDirectory;
        private CCWin.SkinControl.SkinButton btnBrowser;
        private CCWin.SkinControl.SkinLabel lblDownloadProgress;
        private System.Windows.Forms.ToolTip toolTip;
        private CCWin.SkinControl.SkinLabel lblSmile;
        private CCWin.SkinControl.SkinPanel pnlSearchResult;
        private CCWin.SkinControl.SkinLabel lblSongsCount;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel lblSongName;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinListView lvSongList;
        private System.Windows.Forms.ColumnHeader songName;
        private System.Windows.Forms.ColumnHeader songSinger;
        private System.Windows.Forms.ColumnHeader songFormat;
        private System.Windows.Forms.ColumnHeader songBitRate;
        private System.Windows.Forms.ColumnHeader songDuration;
        private System.Windows.Forms.ColumnHeader songSize;
    }
}