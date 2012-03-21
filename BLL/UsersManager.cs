using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;
using DAL;

namespace BLL
{
    public class UsersManager
    {
        public static bool Login(ref Users us, string username, string pass)
        {
            bool isExists = false;
            if ((us = UsersServer.GetUser(username)) == null)
            {
                isExists = false;
            }
            else
            {
                if (us.Pass.Equals (pass))
                {
                    isExists = true;
                }
                else
                {
                    isExists = false;
                }
            }
            return isExists;
        }
        public static bool Register(Users us)
        {
            bool isSuccess = false;

            Users tmp = UsersServer.GetUser(us.Username);
            if (tmp==null)
            {
                UsersServer.InserUser(us);
                isSuccess = true;
            }
            else
            {
                isSuccess = false;
            }
            return isSuccess;
        }

        public static int UpdateUser(Users us) { return UsersServer.UpdateUser(us); }
    }
}
