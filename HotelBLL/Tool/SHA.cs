
using System;
using System.Security.Cryptography;
using System.Text;

namespace Hotel.BLL
{
    /// <summary>
    /// SHA加密
    /// </summary>
    public class SHA//SHA为不可逆加密方式
    {
        /// <summary>
        /// SHA1加密
        /// </summary>
        /// <param name="normalTxt">加密字符串</param>
        /// <returns>加密后明文</returns>
        public string SHA1Encrypt(string normalTxt)
        {
            var bytes = Encoding.Default.GetBytes(normalTxt);
            var SHA = new SHA1CryptoServiceProvider();
            var encryptbytes = SHA.ComputeHash(bytes);
            return Convert.ToBase64String(encryptbytes);
        }

        /// <summary>
        /// SHA256加密
        /// </summary>
        /// <param name="normalTxt">加密字符串</param>
        /// <returns>加密后明文</returns>
        public string SHA256Encrypt(string normalTxt)
        {
            var bytes = Encoding.Default.GetBytes(normalTxt);
            var SHA256 = new SHA256CryptoServiceProvider();
            var encryptbytes = SHA256.ComputeHash(bytes);
            return Convert.ToBase64String(encryptbytes);
        }

        /// <summary>
        /// SHA384加密
        /// </summary>
        /// <param name="normalTxt">加密字符串</param>
        public string SHA384Encrypt(string normalTxt)
        {
            var bytes = Encoding.Default.GetBytes(normalTxt);
            var SHA384 = new SHA384CryptoServiceProvider();
            var encryptbytes = SHA384.ComputeHash(bytes);
            return Convert.ToBase64String(encryptbytes);
        }

        /// <summary>
        /// SHA512加密
        /// </summary>
        /// <param name="normalTxt">加密字符串</param>
        public string SHA512Encrypt(string normalTxt)
        {
            var bytes = Encoding.Default.GetBytes(normalTxt);
            var SHA512 = new SHA512CryptoServiceProvider();
            var encryptbytes = SHA512.ComputeHash(bytes);
            return Convert.ToBase64String(encryptbytes);
        }
    }
}