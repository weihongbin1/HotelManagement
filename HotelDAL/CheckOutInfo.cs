using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    /// <summary>
    /// 退房信息
    /// </summary>
    public class CheckOutInfo : GuestRecord
    {
        /// <summary>
        /// 总金额
        /// </summary>
        public double TotalAmount { get; set; }
        /// <summary>
        /// 应付
        /// </summary>
        public double Difference { get; set; }

    }
}
