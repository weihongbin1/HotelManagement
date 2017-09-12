using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    /// <summary>
    /// 入住登记命令类
    /// </summary>
    public class FrmCheckComm
    {
        /// <summary>
        /// 绑定房间类型
        /// </summary>
        /// <returns>房间类型对象集合</returns>
        public List<RoomType> BindingRoomType()
        {
            List<RoomType> list = new List<RoomType>();
            string sql = string.Format(@"SELECT [TypeName]+CASE WHEN [TypeWindow]=0 THEN ' | 无窗' 
                WHEN [TypeWindow]=1 THEN ' | 有窗'END,[TypeId]
                FROM [dbo].[RoomType]");
            SqlDataReader r = DBHerper.Reader(sql);
            while (r.Read())
            {
                RoomType type = new RoomType() { TypeName = r[0].ToString(), TypeId = Convert.ToInt32(r[1]) };
                list.Add(type);
            }
            r.Close();
            return list;
        }

        /// <summary>
        /// 根据类型绑定房间
        /// </summary>
        /// <param name="typeId">房间类型ID</param>
        /// <returns>房间对象集合</returns>
        public List<Room> BindingRoom(string typeId)
        {
            List<Room> list = new List<Room>();
            string sql = string.Format(@"select [RoomId],[TypePrice]
                from [dbo].[Room] R,[dbo].[RoomType] T
                where(R.RoomTypeId=T.TypeId) and([RoomTypeId]='{0}' and [RoomStateId]='2')", typeId);
            SqlDataReader r = DBHerper.Reader(sql);
            while (r.Read())
            {
                Room room = new Room() { RoomId=Convert.ToInt32(r["RoomId"]), TypePrice=Convert.ToDouble(r["TypePrice"]) };
                list.Add(room);
            }
            r.Close();
            return list;
        }
    }
}
