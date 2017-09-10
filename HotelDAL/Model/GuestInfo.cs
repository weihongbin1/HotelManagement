using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    /// <summary>
    /// 客户信息表
    /// </summary>
    public class GuestInfo
    {
        /// <summary>
        /// 客户ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 客户姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 身份证号码
        /// </summary>
        public string CardNo { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public bool Sex { get; set; }
    }
}
