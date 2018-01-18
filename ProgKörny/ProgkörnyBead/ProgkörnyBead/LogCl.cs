using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgkörnyBead
{
    class LogCl
    {
        private string username;
        public  string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public LogCl()
        {
            this.username = "user";
            this.password = "1234";
        }
        public LogCl(string username , string password) : this()
        {
            this.username = username;
            this.password = password;
        }
        public string ChangeUserName(string user)
        {

            username = user;
            return username;
        }
        public string ChangePassWd(string pass)
        {
            password = pass;
            return password;
        }
    }
}
