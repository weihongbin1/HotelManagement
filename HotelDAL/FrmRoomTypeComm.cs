using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel.DAL
{
    /// <summary>
    /// 类型管理命令类
    /// </summary>
    public class FrmRoomTypeComm
    {
        /// <summary>
        /// 查询全部房间类型名称
        /// </summary>
        /// <returns>房间类型集合</returns>
        public List<string> Querys()
        {
            List<string> s = new List<string>();
            string sql = "SELECT [TypeName] FROM [dbo].[RoomType] GROUP BY [TypeName]";
            SqlDataReader r = DBHerper.Reader(sql);
            while (r.Read())
            {
                s.Add(r[0].ToString());
            }
            r.Close();
            return s;
        }

        /// <summary>
        /// 查询全部房间类型信息
        /// </summary>
        /// <returns></returns>
        public List<RoomType> QueryInfo()
        {
            List<RoomType> li = new List<RoomType>();
            string sql = string.Format(@"SELECT [TypeId],[TypeName],[BedNum],
                CASE WHEN [TypeWindow]=1 THEN '有' WHEN [TypeWindow]=0 THEN '无'END ,
                [TypePrice]
                FROM [dbo].[RoomType]");
            SqlDataReader r = DBHerper.Reader(sql);
            while (r.Read())
            {
                RoomType type = new RoomType() { TypeId = Convert.ToInt32(r[0]), TypeName = r[1].ToString(), BedNum = Convert.ToInt32(r[2]), TypeWindows = r[3].ToString(), TypePrice = Convert.ToDouble(r[4]) };
                li.Add(type);
            }
            r.Close();
            return li;
        }

        /// <summary>
        /// 新增房间类型
        /// </summary>
        /// <param name="type">房间类型对象</param>
        /// <returns>新增的类型编号</returns>
        public object AddType(RoomType type)
        {
            string sql = string.Format(@"INSERT [dbo].[RoomType] ([TypeName], [TypeWindow], [BedNum], [TypePrice])
                VALUES('{0}','{1}','{2}','{3}') SELECT @@IDENTITY", type.TypeName, type.TypeWindow, type.BedNum, type.TypePrice);
            object obj = DBHerper.Scalar(sql);
            return obj;
        }

        /// <summary>
        /// 修改房间类型
        /// </summary>
        /// <param name="type">type</param>
        /// <returns>是否修改成功</returns>
        public bool UpdateType(RoomType type)
        {
            string sql = string.Format(@"UPDATE [dbo].[RoomType]
                SET [TypeName]='{0}',[TypeWindow]='{1}',[BedNum]='{2}',[TypePrice]='{3}'
                WHERE [TypeId]='{4}'", type.TypeName, type.TypeWindow, type.BedNum, type.TypePrice, type.TypeId);
            return (DBHerper.NonQuery(sql) == 1) ? true : false;
        }

        /// <summary>
        /// 判断类型的房间是否存在
        /// </summary>
        /// <param name="id">类型ID</param>
        /// <returns>是否存在</returns>
        public bool JudgeTypeId(string id)
        {
            string sql = string.Format(@"SELECT COUNT(*)
                FROM [dbo].[Room]
                WHERE [RoomTypeId] ='{0}'", id);
            object judge = DBHerper.Scalar(sql);
            return (Convert.ToInt32(judge) != 0) ? true : false;
        }

        /// <summary>
        /// 删除房间类型
        /// </summary>
        /// <param name="id">id</param>
        /// <returns>是否删除成功</returns>
        public bool DeleteType(string id)
        {
            string sql = string.Format(@"DELETE [dbo].[RoomType]
                WHERE [TypeId]='{0}'", id);
            object judge = DBHerper.NonQuery(sql);
            return (Convert.ToInt32(judge) != 0) ? true : false;
        }
    }
}
