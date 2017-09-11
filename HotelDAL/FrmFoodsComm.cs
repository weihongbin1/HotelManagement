using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel.DAL
{
    /// <summary>
    /// 商品命令类
    /// </summary>
    public class FrmFoodsComm
    {
        /// <summary>
        /// 获取食品信息
        /// </summary>
        /// <returns>商品集合</returns>
        public List<FoodList> GetFood()
        {
            List<FoodList> f = new List<FoodList>();
            string sql = string.Format(@"SELECT [FoodId], [FoodName], [Unit], [Price]
                FROM [dbo].[FoodList]");
            SqlDataReader r = DBHerper.Reader(sql);
            while (r.Read())
            {
                FoodList fl = new FoodList() { FoodId = Convert.ToInt32(r[0]), FoodName = r[1].ToString(), Unit = r[2].ToString(), Price = Convert.ToDouble(r[3]) };
                f.Add(fl);
            }
            r.Close();
            return f;
        }

        /// <summary>
        /// 筛选商品信息
        /// </summary>
        /// <param name="FoodName">商品名称</param>
        /// <returns>商品信息集合</returns>
        public List<FoodList> GetFood(string FoodName)
        {
            List<FoodList> f = new List<FoodList>();
            string sql = string.Format(@"SELECT [FoodId], [FoodName], [Unit], [Price]
                FROM [dbo].[FoodList]");
            if (!FoodName.Trim().Equals(string.Empty))
            {
                sql += string.Format(" WHERE [FoodName] like '%{0}%'", FoodName);
            }
            SqlDataReader r = DBHerper.Reader(sql);
            while (r.Read())
            {
                FoodList fl = new FoodList() { FoodId = Convert.ToInt32(r[0]), FoodName = r[1].ToString(), Unit = r[2].ToString(), Price = Convert.ToDouble(r[3]) };
                f.Add(fl);
            }
            r.Close();
            return f;
        }

        /// <summary>
        /// 判断此食品ID是否有订单
        /// </summary>
        /// <param name="id">商品ID</param>
        /// <returns>是否有订单</returns>
        public bool JudgeFoodsOrders(string id)
        {
            string sql = string.Format(@"SELECT COUNT(*)
                FROM [dbo].[FoodOrder]
                WHERE [FoodId]='{0}'",id);
            int judge = Convert.ToInt32(DBHerper.Scalar(sql));
            if (judge!=0)
            {
                return true ;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除食品
        /// </summary>
        /// <param name="id">商品ID</param>
        /// <returns>是否删除成功</returns>
        public bool DeleteFoods(string id)
        {
            string sql = string.Format(@"DELETE [dbo].[FoodList]
                WHERE [FoodId]='{0}'", id);
            int judge = DBHerper.NonQuery(sql);
            if (judge == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 增加商品
        /// </summary>
        /// <param name="food">商品对象</param>
        /// <returns>增加的商品编号</returns>
        public object AddFoods(FoodList food)
        {
            string sql = string.Format(@"INSERT [dbo].[FoodList] ([FoodName], [Unit], [Price])
                VALUES('{0}','{1}','{2}') SELECT @@IDENTITY", food.FoodName,food.Unit,food.Price);
            object judge = DBHerper.Scalar(sql);
            return judge;
        }

        /// <summary>
        /// 修改商品
        /// </summary>
        /// <param name="food">商品对象</param>
        /// <returns>是否修改成功</returns>
        public bool UpdateFoods(FoodList food)
        {
            string sql = string.Format(@"UPDATE  [dbo].[FoodList]
                SET [FoodName]='{0}',[Unit]='{1}',[Price]='{2}'
                WHERE [FoodId]='{3}'",food.FoodName,food.Unit,food.Price,food.FoodId);
            int judge = Convert.ToInt32(DBHerper.NonQuery(sql));
            if (judge!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
