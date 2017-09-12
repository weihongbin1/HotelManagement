using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    /// <summary>
    /// 房间状态表
    /// </summary>
    public class Room : RoomType
    {
        /// <summary>
        /// 房间编号
        /// </summary>
        public int RoomId { get; set; }
        /// <summary>
        /// 房间类型ID
        /// </summary>
        public int RoomTypeId { get; set; }
        /// <summary>
        /// 房间状态ID
        /// </summary>
        public int RoomStateId { get; set; }

    }
}
