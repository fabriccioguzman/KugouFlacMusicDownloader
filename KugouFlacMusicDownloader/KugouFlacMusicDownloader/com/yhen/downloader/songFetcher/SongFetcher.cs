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
            string webSite = "http://mobilecdn.kugou.com/api/v3/search/song?format=json&keyword=" + songName + "&page=1&pagesize=30";
            byte[] buffer = web.DownloadData(webSite);
            string html = Encoding.UTF8.GetString(buffer);
            JObject kugou = JObject.Parse(html);
            List<JToken> all = kugou["data"]["info"].Children().ToList();
            return all;
        }

        public static JObject FetchSong(KugouMusic kg)
        {
            WebClient web = new WebClient();
            string webSite = "http://trackercdn.kugou.com/i/?cmd=4&hash=" + kg.sqhash + "&key=" + kg.key + "&pid=1&forceDown=0&vip=1";
            byte[] buffer = web.DownloadData(webSite);
            string html = Encoding.UTF8.GetString(buffer);
            JObject flac = JObject.Parse(html);
            return flac;
        }
    }
}
