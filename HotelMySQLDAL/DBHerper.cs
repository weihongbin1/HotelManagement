using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Hotel.MySQLDAL
{
    /// <summary>
    /// MySQL数据库连接帮助类
    /// </summary>
    public static  class DBHerper
    {
        /// <summary>
        /// 数据库连接字符串--读取配置文件获取
        /// </summary>
        private static readonly string connStr= ConfigurationManager.ConnectionStrings["HotelConnectionMySql"].ToString();
        
        /// <summary>
        /// 新建连接对象
        /// </summary>
        private static MySqlConnection conn;

        /// <summary>
        /// 封装连接对象
        /// </summary>
        private static MySqlConnection Conn
        {
            get
            {
                if (conn == null)
                {
                    conn = new MySqlConnection(connStr);
                }
                return conn;
            }
        }

        /// <summary>
        /// 打开数据库连接
        /// </summary>
        private static void Open()
        {
            if (Conn.State == ConnectionState.Closed)
            {
                Conn.Open();
            }
            if (Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
                Conn.Open();
            }
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        private static void Close()
        {
            if (Conn.State == ConnectionState.Open || Conn.State == ConnectionState.Broken)
            {
                Conn.Close();
            }
        }


        /// <summary>
        /// 查询返回第一行第一列
        /// </summary>
        /// <param name="sql">SQL命令</param>
        /// <returns>第一行第一列</returns>
        public static object Scalar(string sql)
        {
            object obj = null;
            try
            {
                MySqlCommand command = new MySqlCommand(sql, Conn);
                Open();
                obj = command.ExecuteScalar();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            finally
            {
                Close();
            }
            return obj;
        }

        /// <summary>
        /// 执行增删改，返回受影响行数
        /// </summary>
        /// <param name="sql">SQL命令</param>
        /// <returns>受影响行数</returns>
        public static int NonQuery(string sql)
        {
            int num = 0;
            try
            {
                MySqlCommand command = new MySqlCommand(sql, Conn);
                Open();
                num = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            finally
            {
                Close();
            }
            return num;
        }


        /// <summary>
        /// 查询返回Reader对象
        /// </summary>
        /// <param name="sql">SQL命令</param>
        /// <returns>Reader对象</returns>
        public static MySqlDataReader Reader(string sql)
        {
            MySqlDataReader reader = null;
            try
            {
                MySqlCommand command = new MySqlCommand(sql, Conn);
                Open();
                reader = command.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception e)
            {

                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return reader;
        }

        /// <summary>
        /// 查询返回Adapter对象
        /// </summary>
        /// <param name="sql">SQL命令</param>
        /// <returns>Adapter对象</returns>
        public static MySqlDataAdapter Adapter(string sql)
        {
            MySqlDataAdapter adapter = null;
            try
            {
                adapter = new MySqlDataAdapter(sql, Conn);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return adapter;

        }

    }
}
