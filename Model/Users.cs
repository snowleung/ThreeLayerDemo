using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Users
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
    }
}
