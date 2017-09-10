using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    /// <summary>
    /// 房间类型表
    /// </summary>
    public class RoomType
    {
        /// <summary>
        /// 类型编号
        /// </summary>
        public int TypeId { get; set; }
        /// <summary>
        /// 类型名称
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// 是否有窗
        /// </summary>
        public bool TypeWindow { get; set; }
        /// <summary>
        /// 是否有窗String
        /// </summary>
        public string  TypeWindows { get; set; }
        /// <summary>
        /// 床位数
        /// </summary>
        public int BedNum { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public double TypePrice { get; set; }
        /// <summary>
        /// 图片路径
        /// </summary>
        public string PicturePath { get; set; }
    }
}
