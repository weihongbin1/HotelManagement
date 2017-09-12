using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    /// <summary>
    /// 客人记录表
    /// </summary>
    public class GuestRecord : GuestInfo
    {
        /// <summary>
        /// 记录ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 押金
        /// </summary>
        public double Deposit { get; set; }
        /// <summary>
        /// 入住日期
        /// </summary>
        public DateTime ArrivalDate { get; set; }
        /// <summary>
        /// 入住日期-string类型
        /// </summary>
        public string ArrivalDateStr { get; set; }
        /// <summary>
        /// 退房日期
        /// </summary>
        public DateTime LeaveDate { get; set; }
        /// <summary>
        /// 房款
        /// </summary>
        public double RoomTotal { get; set; }
        /// <summary>
        /// 餐饮费用
        /// </summary>
        public double FoodTotal { get; set; }
        /// <summary>
        /// 客房编号
        /// </summary>
        public int RoomId { get; set; }

    }
}
