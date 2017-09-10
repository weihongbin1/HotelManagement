using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.BLL
{
    /// <summary>
    /// 加密工具
    /// </summary>
   public  class Encrypt
    {
        /// <summary>
        /// 加密字符串
        /// </summary>
        /// <param name="Pwd">待加密字符串</param>
        /// <returns>加密后字符串</returns>
        public string EncryotPwd(string Pwd)
        {
            MD5 m = new MD5();
            SHA s = new SHA();
            return m.MD5Encrypt(s.SHA512Encrypt(s.SHA384Encrypt(s.SHA256Encrypt(s.SHA1Encrypt(Pwd)))));
        }
    }
}
