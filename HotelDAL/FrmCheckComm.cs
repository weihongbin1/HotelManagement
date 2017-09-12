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
                Room room = new Room() { RoomId = Convert.ToInt32(r["RoomId"]), TypePrice = Convert.ToDouble(r["TypePrice"]) };
                list.Add(room);
            }
            r.Close();
            return list;
        }

        /// <summary>
        /// 通过身份证判断客户是否存在
        /// </summary>
        /// <param name="id">身份证</param>
        /// <returns>是否存在</returns>
        public bool CheckExist(string id)
        {
            string sql = string.Format(@"SELECT COUNT(*)
                FROM [dbo].[GuestInfo]
                WHERE [CardNo]='{0}'", id);
            int judge = Convert.ToInt32(DBHerper.Scalar(sql));
            if (judge != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 增加客户信息
        /// </summary>
        /// <param name="info">客户信息</param>
        /// <returns>客户编号</returns>
        public string AddGuestInfo(GuestInfo info)
        {
            string sql = string.Format(@"INSERT [dbo].[GuestInfo]([Name], [CardNo], [Phone], [Sex])
                VALUES ('{0}','{1}','{2}','{3}')
                SELECT @@IDENTITY", info.Name, info.CardNo, info.Phone, info.Sex);
            string guestId = DBHerper.Scalar(sql).ToString();
            return guestId;
        }

        /// <summary>
        /// 修改客户信息
        /// </summary>
        /// <param name="info">客户信息</param>
        /// <returns>客户编号</returns>
        public string UpdateGuestInfo(GuestInfo info)
        {
            string sql = string.Format(@"UPDATE [dbo].[GuestInfo]
                SET [Name]='{0}',[Phone]='{1}',[Sex]='{2}'
                WHERE [CardNo]='{3}'
                SELECT [ID]
                FROM [dbo].[GuestInfo]
                WHERE [CardNo]='{3}'", info.Name, info.Phone, info.Sex, info.CardNo);
            string guestId = DBHerper.Scalar(sql).ToString();
            return guestId;
        }

        /// <summary>
        /// 增加订单
        /// </summary>
        /// <param name="guest">客户记录对象</param>
        public void AddOrder(GuestRecord guest)
        {
            string sql = string.Format(@"INSERT [dbo].[GuestRecord] ( [GuestID], [Deposit], [ArrivalDate], [RoomId])
                VALUES ('{0}','{1}','{2}','{3}')
                UPDATE [dbo].[Room]
                SET [RoomStateId]=1
                WHERE [RoomId]='{3}'", guest.GuestID,guest.Deposit,guest.ArrivalDateStr, guest.RoomId);
            DBHerper.NonQuery(sql);
        } 
    }
}
