using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    /// <summary>
    /// 房间统计
    /// </summary>
    public class RoomStatistics
    {
        /// <summary>
        /// 房间类型
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// 房间数
        /// </summary>
        public int RoomNum { get; set; }
        /// <summary>
        /// 入住
        /// </summary>
        public int Check { get; set; }
        /// <summary>
        /// 空闲
        /// </summary>
        public int Free { get; set; }
        /// <summary>
        /// 维修
        /// </summary>
        public int Repair { get; set; }
        /// <summary>
        /// 入住率
        /// </summary>
        public double CheckRate { get; set; }
        /// <summary>
        /// 初始化属性
        /// </summary>
        public void Initial()
        {
            Type = string.Empty;
            RoomNum = 0;
            Check = 0;
            Free = 0;
            Repair = 0;
        }
    }
}
