using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    /// <summary>
    /// 食品列表表
    /// </summary>
    public class FoodList
    {
        /// <summary>
        /// ID
        /// </summary>
        public int FoodId { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string FoodName { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string Unit { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public double Price { get; set; }
    }
}
