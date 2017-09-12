using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAL
{
    /// <summary>
    /// 单个房间命令类
    /// </summary>
    public class FrmSingleMainComm
    {
        /// <summary>
        /// 获取房间状态
        /// </summary>
        /// <param name="roomId">房间编号</param>
        /// <returns>房间状态</returns>
        public int GetStatistics(string roomId)
        {
            string sql = string.Format(@"SELECT [RoomStateId]
                FROM [dbo].[Room]
                WHERE [RoomId]='{0}'", roomId);
            int judge = Convert.ToInt32(DBHerper.Scalar(sql));
            return judge;
        }
    }
}
