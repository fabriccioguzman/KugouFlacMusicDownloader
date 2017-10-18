using System.Security.Cryptography;
using System.Text;

namespace com.yhen.downloader.encryptor
{
    /// <summary>
    /// MD5 加密工具
    /// </summary>
    public class MD5Encryptor
    {
        /// <summary>
        /// MD5 加密
        /// </summary>
        /// <param name="source">需加密的字符串</param>
        /// <returns>经MD5加密的字符串</returns>
        public static string Encrypt(string source)
        {
            MD5 md5 = MD5.Create();
            byte[] bf = Encoding.Default.GetBytes(source);
            byte[] mbf = md5.ComputeHash(bf);
            string s = "";
            for (int i = 0; i < mbf.Length; i++)
            {
                s += mbf[i].ToString("x2");
            }
            return s;
        }
    }
}
