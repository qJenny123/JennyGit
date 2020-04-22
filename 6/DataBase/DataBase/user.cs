using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataBase
{
    class user
    {
        //用户基本属性的定义以及get与set，自动生成比较乱
        private int id;
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string sex;

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        private string nickname;
        private string bithday;

        public string Bithday
        {
            get { return bithday; }
            set { bithday = value; }
        }
        private string regtime;

        public string Regtime
        {
            get { return regtime; }
            set { regtime = value; }
        }


        //get set
        public string Nickname
        {
            get { return nickname; }
            set { nickname = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
