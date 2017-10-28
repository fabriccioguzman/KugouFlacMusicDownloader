using com.yhen.downloader.vo;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace com.yhen.downloader.songFetcher
{
    public class SongFetcher
    {
        public static List<JToken> FetchSongInfo(string songName)
        {
            WebClient web = new WebClient();
            string webSite = "http://mobilecdn.kugou.com/api/v3/search/song?format=json&keyword=" + songName + "&page=1&pagesize=1000";
            byte[] buffer = web.DownloadData(webSite);
            string html = Encoding.UTF8.GetString(buffer);
            JObject kugou = JObject.Parse(html);
            List<JToken> all = kugou["data"]["info"].Children().ToList();
            return all;
        }

        public static JObject FetchSong(KugouMusic kg)
        {
            WebClient web = new WebClient();
            string webSite = "http://trackercdn.kugou.com/i/?cmd=4&hash=" + kg.sqhash + "&key=" + kg.key + "&pid=1&forceDown=0&vip=1&acceptMp3=1";
            byte[] buffer = web.DownloadData(webSite);
            string html = Encoding.UTF8.GetString(buffer);
            JObject flac = JObject.Parse(html);
            return flac;
        }

        public static JObject FetchSongForM4A(KugouMusic kg)
        {
            WebClient web = new WebClient();
            string webSite = "http://trackercdn.kugou.com/i/?cmd=3&hash=" + kg.sqhash + "&key=" + kg.key + "&pid=1&forceDown=0&vip=1&acceptMp3=1";
            byte[] buffer = web.DownloadData(webSite);
            string html = Encoding.UTF8.GetString(buffer);
            JObject m4a = JObject.Parse(html);
            return m4a;
        }

        public static JObject FetchSongForMP3(KugouMusic kg)
        {
            WebClient web = new WebClient();
            string webSite = "http://trackercdn.kugou.com/i/?cmd=4&hash=" + kg.hash + "&key=" + kg.key + "&pid=1&forceDown=0&vip=1&acceptMp3=1";
            byte[] buffer = web.DownloadData(webSite);
            string html = Encoding.UTF8.GetString(buffer);
            JObject mp3 = JObject.Parse(html);
            return mp3;
        }
    }
}
