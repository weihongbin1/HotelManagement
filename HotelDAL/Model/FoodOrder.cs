using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    /// <summary>
    /// 食品订单表
    /// </summary>
    public class FoodOrder
    {
        /// <summary>
        /// 订单ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 食品ID
        /// </summary>
        public int FoodId { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        public int num { get; set; }
        /// <summary>
        /// 订单时间
        /// </summary>
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// 房间编号
        /// </summary>
        public int RoomId { get; set; }
       
    }
}
