using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hotel.DAL
{
    /// <summary>
    /// 顾客记录查询命令
    /// </summary>
    public class FrmGuestInfoComm
    {
        /// <summary>
        /// 加载客户记录(未结账)
        /// </summary>
        /// <returns>客户记录对象集合</returns>
        public List<GuestRecord> LoadOrder()
        {
            List<GuestRecord> list = new List<GuestRecord>();
            string sql = string.Format(@"SELECT [RoomId],[Name],[CardNo],[Phone],CASE WHEN [Sex]=0 THEN '男' WHEN [Sex]=1 THEN '女' END,[Deposit],[ArrivalDate],R.ID
                FROM [dbo].[GuestInfo] G,[dbo].[GuestRecord] R
                WHERE G.ID=R.GuestID AND [LeaveDate] IS  NULL");
            SqlDataReader r = DBHerper.Reader(sql);
            while (r.Read())
            {
                GuestRecord record = new GuestRecord() { RoomId = Convert.ToInt32(r[0]), Name = r[1].ToString(), CardNo = r[2].ToString(), Phone = r[3].ToString(), SexStr = r[4].ToString(), Deposit = Convert.ToDouble(r[5]), ArrivalDate = Convert.ToDateTime(r[6]), ID = Convert.ToInt32(r[7]) };
                list.Add(record);
            }
            r.Close();
            return list;
        }

        /// <summary>
        /// 筛选订单-按姓名筛选
        /// </summary>
        /// <param name="name">客户姓名</param>
        /// <returns>客户记录对象集合</returns>
        public List<GuestRecord> ScreenOrder(string name)
        {
            List<GuestRecord> list = new List<GuestRecord>();
            string sql = string.Format(@"SELECT [RoomId],[Name],[CardNo],[Phone],CASE WHEN [Sex]=0 THEN '男' WHEN [Sex]=1 THEN '女' END,[Deposit],[ArrivalDate],R.ID
                FROM [dbo].[GuestInfo] G,[dbo].[GuestRecord] R
                WHERE G.ID=R.GuestID AND [LeaveDate] IS  NULL AND [Name] LIKE '%{0}%'", name);
            SqlDataReader r = DBHerper.Reader(sql);
            while (r.Read())
            {
                GuestRecord record = new GuestRecord() { RoomId = Convert.ToInt32(r[0]), Name = r[1].ToString(), CardNo = r[2].ToString(), Phone = r[3].ToString(), SexStr = r[4].ToString(), Deposit = Convert.ToDouble(r[5]), ArrivalDate = Convert.ToDateTime(r[6]), ID = Convert.ToInt32(r[7]) };
                list.Add(record);
            }
            r.Close();
            return list;

        }

        /// <summary>
        /// 筛选订单-按房间编号筛选
        /// </summary>
        /// <param name="RoomID">房间编号</param>
        /// <returns>客户记录对象集合</returns>
        public List<GuestRecord> ScreenOrder(int RoomID)
        {
            List<GuestRecord> list = new List<GuestRecord>();
            string sql = string.Format(@"SELECT [RoomId],[Name],[CardNo],[Phone],CASE WHEN [Sex]=0 THEN '男' WHEN [Sex]=1 THEN '女' END,[Deposit],[ArrivalDate],R.ID
                FROM [dbo].[GuestInfo] G,[dbo].[GuestRecord] R
                WHERE G.ID=R.GuestID AND [LeaveDate] IS  NULL AND [RoomId] LIKE '%{0}%'", RoomID);
            SqlDataReader r = DBHerper.Reader(sql);
            while (r.Read())
            {
                GuestRecord record = new GuestRecord() { RoomId = Convert.ToInt32(r[0]), Name = r[1].ToString(), CardNo = r[2].ToString(), Phone = r[3].ToString(), SexStr = r[4].ToString(), Deposit = Convert.ToDouble(r[5]), ArrivalDate = Convert.ToDateTime(r[6]), ID = Convert.ToInt32(r[7]) };
                list.Add(record);
            }
            r.Close();
            return list;

        }

        /// <summary>
        /// 退房信息
        /// </summary>
        /// <param name="id">记录编号</param>
        /// <returns>退房信息对象</returns>
        public CheckOutInfo CheckOutInfo(string id)
        {
            CheckOutInfo outInfo = new DAL.CheckOutInfo();
            string sql = string.Format(@"SELECT [Deposit],DATEDIFF(DAY,[ArrivalDate],
                GETDATE())*(SELECT [TypePrice] FROM [dbo].[RoomType] WHERE [TypeId]=
                (SELECT [RoomTypeId] FROM [dbo].[Room] WHERE [RoomId]=(select [RoomId] from [dbo].[GuestRecord] where [ID]={0}))),
                (SELECT SUM([Num]*[Price])
                FROM [dbo].[FoodOrder] F,[dbo].[FoodList] L
                WHERE (F.FoodId=L.FoodId) AND [RoomId]=(SELECT [RoomId] FROM [dbo].[GuestRecord] WHERE [ID]={0}) 
                AND [OrderDate]>=(SELECT [ArrivalDate] FROM [dbo].[GuestRecord] WHERE [ID]={0}))
                FROM [dbo].[GuestRecord]
                WHERE [RoomId]=(SELECT [RoomId] FROM [dbo].[GuestRecord] WHERE [ID]={0}) AND [LeaveDate] IS NULL AND [ID]={0}", id);
            SqlDataReader r = DBHerper.Reader(sql);
            if (r.Read())
            {
                outInfo.Deposit = Convert.ToDouble(r[0]);
                outInfo.RoomTotal = Convert.ToDouble(r[1]);
                if (r[2].ToString().Equals(string.Empty))
                {
                    outInfo.FoodTotal = 0;
                }
                else
                {
                    outInfo.FoodTotal = Convert.ToDouble(r[2]);
                }
                outInfo.TotalAmount = outInfo.FoodTotal + outInfo.RoomTotal - outInfo.Deposit;
            }
            r.Close();
            return outInfo;
        }

        /// <summary>
        /// 退房
        /// </summary>
        /// <param name="RoomTotal">房款</param>
        /// <param name="FoodTotal">消费</param>
        /// <param name="id">订单号</param>
        /// <returns>是否退房成功</returns>
        public void CheckOut(string RoomTotal, string FoodTotal, string id)
        {
            string sql = string.Format(@"UPDATE [dbo].[GuestRecord]
                SET [LeaveDate]=GETDATE(),[RoomTotal]='{0}',[FoodTotal]='{1}'
                WHERE [ID]='{2}'
                UPDATE [dbo].[Room]
                SET [RoomStateId]=2
                WHERE [RoomId]=
                (SELECT [RoomId] FROM  [dbo].[GuestRecord] WHERE [ID]='{2}')", RoomTotal, FoodTotal, id);
            DBHerper.NonQuery(sql);
        }

        /// <summary>
        /// 加载记录
        /// </summary>
        /// <returns>记录集合</returns>
        public List<GuestRecord> LoadRecord()
        {
            List<GuestRecord> list = new List<GuestRecord>();
            string sql = string.Format(@"SELECT [RoomId],[Name],[CardNo],[Phone],CASE WHEN [Sex]=0 THEN '男' WHEN [Sex]=1 THEN '女' END,[Deposit],[ArrivalDate],[LeaveDate],[RoomTotal],[FoodTotal],R.[ID]
                FROM [dbo].[GuestInfo] G,[dbo].[GuestRecord] R
                WHERE G.ID=R.GuestID AND [LeaveDate] IS NOT NULL");
            SqlDataReader r = DBHerper.Reader(sql);
            while (r.Read())
            {
                GuestRecord g = new GuestRecord() { RoomId = Convert.ToInt32(r[0]), Name = r[1].ToString(), CardNo = r[2].ToString(), Phone = r[3].ToString(), SexStr = r[4].ToString(), Deposit = Convert.ToDouble(r[5]), ArrivalDate = Convert.ToDateTime(r[6]), LeaveDate = Convert.ToDateTime(r[7]), RoomTotal = Convert.ToDouble(r[8]), FoodTotal = Convert.ToDouble(r[9]), ID = Convert.ToInt32(r[10]) };
                list.Add(g);
            }
            r.Close();
            return list;
        }

        /// <summary>
        /// 按姓名筛选记录
        /// </summary>
        /// <param name="name">姓名</param>
        /// <returns>记录对象集合</returns>
        public List<GuestRecord> ScreenRecord(string name)
        {
            List<GuestRecord> list = new List<GuestRecord>();
            string sql = string.Format(@"SELECT [RoomId],[Name],[CardNo],[Phone],CASE WHEN [Sex]=0 THEN '男' WHEN [Sex]=1 THEN '女' END,[Deposit],[ArrivalDate],[LeaveDate],[RoomTotal],[FoodTotal],R.[ID]
                FROM [dbo].[GuestInfo] G,[dbo].[GuestRecord] R
                WHERE G.ID=R.GuestID AND [LeaveDate] IS NOT NULL
                AND [Name] LIKE '%{0}%'", name);
            SqlDataReader r = DBHerper.Reader(sql);
            while (r.Read())
            {
                GuestRecord g = new GuestRecord() { RoomId =Convert.ToInt32(r[0]), Name=r[1].ToString(), CardNo=r[2].ToString(), Phone=r[3].ToString(), SexStr=r[4].ToString(), Deposit=Convert.ToDouble(r[5]), ArrivalDate=Convert.ToDateTime(r[6]), LeaveDate=Convert.ToDateTime(r[7]), RoomTotal=Convert.ToDouble(r[8]),FoodTotal=Convert.ToDouble(r[9]), ID=Convert.ToInt32(r[10]) };
                list.Add(g);
            }
            r.Close();
            return list;
        }

        /// <summary>
        /// 按房间编号筛选记录
        /// </summary>
        /// <param name="roomId">房间编号</param>
        /// <returns>记录对象集合</returns>
        public List<GuestRecord> ScreenRecord(int roomId)
        {
            List<GuestRecord> list = new List<GuestRecord>();
            string sql = string.Format(@"SELECT [RoomId],[Name],[CardNo],[Phone],CASE WHEN [Sex]=0 THEN '男' WHEN [Sex]=1 THEN '女' END,[Deposit],[ArrivalDate],[LeaveDate],[RoomTotal],[FoodTotal],R.[ID]
                FROM [dbo].[GuestInfo] G,[dbo].[GuestRecord] R
                WHERE G.ID=R.GuestID AND [LeaveDate] IS NOT NULL
                AND [RoomId] LIKE '%{0}%'", roomId);
            SqlDataReader r = DBHerper.Reader(sql);
            while (r.Read())
            {
                GuestRecord g = new GuestRecord() { RoomId = Convert.ToInt32(r[0]), Name = r[1].ToString(), CardNo = r[2].ToString(), Phone = r[3].ToString(), SexStr = r[4].ToString(), Deposit = Convert.ToDouble(r[5]), ArrivalDate = Convert.ToDateTime(r[6]), LeaveDate = Convert.ToDateTime(r[7]), RoomTotal = Convert.ToDouble(r[8]), FoodTotal = Convert.ToDouble(r[9]), ID = Convert.ToInt32(r[10]) };
                list.Add(g);
            }
            r.Close();
            return list;

        }
    }
}
