using System;
using System.Security.Cryptography;
using System.Text;

namespace Hotel.BLL
{
    /// <summary>
    /// MD5加密
    /// </summary>
    public class MD5
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="normalTxt">加密字符串</param>
        /// <returns>加密明文</returns>
        public string MD5Encrypt(string normalTxt)
        {
            var bytes = Encoding.Default.GetBytes(normalTxt);//求Byte[]数组
            var Md5 = new MD5CryptoServiceProvider().ComputeHash(bytes);//求哈希值
            return Convert.ToBase64String(Md5);//将Byte[]数组转为净荷明文(其实就是字符串)
        }
    }
}
