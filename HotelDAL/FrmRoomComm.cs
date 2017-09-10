using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel.DAL
{
    /// <summary>
    /// 房间管理命令类
    /// </summary>
    public class FrmRoomComm
    {
        /// <summary>
        /// 获取全部房间类型
        /// </summary>
        /// <returns>房间类型列表</returns>
        public List<RoomTypeList> GetTypeList()
        {
            List<RoomTypeList> list = new List<RoomTypeList>();
            string sql = string.Format(@"SELECT TypeName+CASE  WHEN TypeWindow=0 THEN ' | 无窗' WHEN TypeWindow=1 THEN ' | 有窗' END,TypeId
                FROM RoomType");
            SqlDataReader r = DBHerper.Reader(sql);
            while (r.Read())
            {
                RoomTypeList l = new RoomTypeList() { TypeName = r[0].ToString(), TypeID = r[1].ToString() };
                list.Add(l);
            }
            r.Close();
            return list;
        }

        /// <summary>
        /// 获取全部房间信息
        /// </summary>
        /// <returns>房间信息列表</returns>
        public List<RoomTypeList> GetRoomInfo()
        {
            List<RoomTypeList> list = new List<RoomTypeList>();
            string sql = string.Format(@"SELECT RoomId,RoomStateName,TypeName+CASE  WHEN TypeWindow=0 THEN ' | 无窗' WHEN TypeWindow=1 THEN ' | 有窗' END
                FROM RoomType AS T,Room AS R,RoomState AS S
                WHERE R.RoomTypeId=T.TypeId AND R.RoomStateId=S.RoomStateId");
            SqlDataReader r = DBHerper.Reader(sql);
            while (r.Read())
            {
                RoomTypeList l = new RoomTypeList() { TypeID = r[0].ToString(), StateName = r[1].ToString(), TypeName = r[2].ToString() };
                list.Add(l);
            }
            r.Close();

            return list;
        }

        /// <summary>
        /// 获取全部房间信息并筛选
        /// </summary>
        /// <param name="id">房间ID</param>
        /// <returns>房间信息列表</returns>
        public List<RoomTypeList> GetRoomInfo(string id)
        {
            List<RoomTypeList> list = new List<RoomTypeList>();
            string sql = string.Format(@"SELECT RoomId,RoomStateName,TypeName+CASE  WHEN TypeWindow=0 THEN ' | 无窗' WHEN TypeWindow=1 THEN ' | 有窗' END
                FROM RoomType AS T,Room AS R,RoomState AS S
                WHERE (R.RoomTypeId=T.TypeId AND R.RoomStateId=S.RoomStateId) AND RoomId LIKE '%{0}%'", id);
            SqlDataReader r = DBHerper.Reader(sql);
            while (r.Read())
            {
                RoomTypeList l = new RoomTypeList() { TypeID = r[0].ToString(), StateName = r[1].ToString(), TypeName = r[2].ToString() };
                list.Add(l);
            }
            r.Close();

            return list;
        }

        /// <summary>
        /// 增加房间信息
        /// </summary>
        /// <param name="room">房间信息</param>
        /// <returns>是否增加成功</returns>
        public bool AddRoom(Room room)
        {
            string sql = string.Format(@"SELECT count(*)
                FROM Room
                WHERE RoomId='{0}'",room.RoomId);
            if (Convert.ToInt32( DBHerper.Scalar(sql))!=0)
            {
                return false;
            }
            else
            {
                sql = string.Format(@"INSERT Room VALUES ('{0}','{1}','{2}')",room.RoomId, room.RoomTypeId, room.RoomStateId);
                if (Convert.ToInt32( DBHerper.NonQuery(sql))==1)
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
}
