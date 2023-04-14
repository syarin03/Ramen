using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RamenServer
{
    public class DatabaseManager
    {
        public DatabaseManager() { }

        public static string server_str = "10.10.21.116"; //DB 서버 주소, 로컬일 경우 localhost
        public static int port_num = 3306; //DB 서버 포트
        public static string schema_str = "work0403"; //DB 이름
        public static string id_str = "work0403_admin"; //계정 아이디
        public static string pw_str = "admin1234"; //계정 비밀번호
        public static string connect_str = $"Server={server_str};Port={port_num};Database={schema_str};Uid={id_str};Pwd={pw_str}";

        public static int gAcc = 0;

        public static DataTable GetDataTable(string mySql)
        {
            using (MySqlConnection myConn = new MySqlConnection(connect_str))
            {
                myConn.Open();
                MySqlCommand sc = new MySqlCommand(mySql, myConn);
                MySqlDataReader reader;
                DataTable dt = new DataTable();
                reader = sc.ExecuteReader();
                dt.Load(reader);

                return dt;
            }
        }

        public static int GetDataCount(string mySql)
        {
            using (MySqlConnection myConn = new MySqlConnection(connect_str))
            {
                myConn.Open();
                MySqlCommand sc = new MySqlCommand(mySql, myConn);
                int count = Convert.ToInt32(sc.ExecuteScalar());

                return count;
            }
        }

        public static void InsertData(string mysql)
        {
            using (MySqlConnection myConn = new MySqlConnection(connect_str))
            {
                myConn.Open();

                MySqlCommand sc = new MySqlCommand(mysql, myConn);
                sc.ExecuteNonQuery();
            }
        }

        public static void ConnectTest()
        {
            try
            {
                using (MySqlConnection myConn = new MySqlConnection(connect_str))
                {
                    myConn.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}