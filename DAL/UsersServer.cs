using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class UsersServer
    {
        public static Users GetUser(string username)
        {
            Users us = null;
            string sql = "select * from users where username=@username";
            SqlParameter[] parms = { new SqlParameter("@username", username) };
            SqlDataReader rder = SqlHelper.ExecuteReader(SqlHelper.sqlconn, CommandType.Text, sql, parms);
            if (rder.Read())
            {
                us = new Users();
                us.Id = Convert.ToInt32(rder["id"]);
                us.Pass = rder["pass"].ToString();
                us.Username = rder["username"].ToString();
            }
            return us;
        }

        public static int InserUser(Users us)
        {
            string sql = "insert into users values(@username,@pass)";
            SqlParameter[] parms = { new SqlParameter("@username", us.Username), new SqlParameter("@pass", us.Pass) };
            return SqlHelper.ExecuteNonQuery(SqlHelper.sqlconn, CommandType.Text, sql, parms);
        }
        public static int UpdateUser(Users us)
        {
            string sql = "update users set Username=@username,Pass=@pass where id=@id";
            SqlParameter[] parms = { new SqlParameter("@id", us.Id), new SqlParameter("@username", us.Username), new SqlParameter("@pass", us.Pass) };
            return SqlHelper.ExecuteNonQuery(SqlHelper.sqlconn, CommandType.Text, sql, parms);
        }
    }
}
