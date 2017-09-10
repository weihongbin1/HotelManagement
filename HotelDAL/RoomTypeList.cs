using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    /// <summary>
    /// 房间类型名称（是否有窗）
    /// </summary>
    public class RoomTypeList
    {
        /// <summary>
        /// 房间类型名称
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// 房间类型ID
        /// </summary>
        public string TypeID { get; set; }
        /// <summary>
        /// 房间状态
        /// </summary>
        public string StateName { get; set; }
    }
}
