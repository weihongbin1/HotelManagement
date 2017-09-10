using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Hotel.DAL
{
    /// <summary>
    /// 主窗体加载命令
    /// </summary>
    public class FrmMainComm
    {
        /// <summary>
        /// 获取全部房间信息系
        /// </summary>
        /// <returns>房间信息集合</returns>
        public List<RoomInfo> GetRoomInfo()
        {
            List<RoomInfo> info = new List<RoomInfo>();
            string sql = string.Format(@"SELECT [RoomId],[TypeName],CASE WHEN [TypeWindow]=1 THEN '有' WHEN [TypeWindow]=0 THEN '无'END,[RoomStateName]
                FROM [dbo].[Room] R,[dbo].[RoomType] T,[dbo].[RoomState] S
                WHERE R.RoomTypeId=T.TypeId AND R.RoomStateId=S.RoomStateId");
            SqlDataReader r = DBHerper.Reader(sql);
            while (r.Read())
            {
                RoomInfo roomInfo = new RoomInfo() { Number=r[0].ToString(),RoomRype=r[1].ToString(), Window=r[2].ToString(), RoomState=r[3].ToString() };
                info.Add(roomInfo);
            }

            r.Close();
            return info;
        }

        /// <summary>
        /// 添加树列表
        /// </summary>
        /// <param name="treeView">需要添加的控件</param>
        public  void ShowTreeView(TreeView treeView)
        {
            string all = "全部";
            TreeNode node = treeView.Nodes.Add(all);
            string sql = string.Format(@"SELECT TypeName FROM roomtype
            WHERE TypeWindow=1");
            SqlDataReader r = DBHerper.Reader(sql);
            while (r.Read())
            {
                string a = r[0].ToString();
                node.Nodes.Add(a);
            }
            r.Close();
        }
    }
}
