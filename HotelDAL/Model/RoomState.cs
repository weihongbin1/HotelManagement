using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    /// <summary>
    /// 入住状态表
    /// </summary>
    public class RoomState
    {
        /// <summary>
        /// 状态编号
        /// </summary>
        public int RoomStateId { get; set; }
        /// <summary>
        /// 状态名称
        /// </summary>
        public string RoomStateName { get; set; }
    }
}
