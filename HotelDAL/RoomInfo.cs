using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    /// <summary>
    /// 房间信息
    /// </summary>
    public class RoomInfo
    {
        /// <summary>
        /// 房间编号
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// 房间类型
        /// </summary>
        public string  RoomRype { get; set; }
        /// <summary>
        /// 房间状态
        /// </summary>
        public string RoomState { get; set; }
        /// <summary>
        /// 是否有窗
        /// </summary>
        public string Window { get; set; }
    }
}
