using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using NUnit.Framework;

namespace DataBase
{
    class DataBaseTest
    {
        private DataBase dbUser;
        [TestFixtureSetUp]
        public void Init()
        {
            dbUser = new DataBase();
        }
        //添加一个获取最大值的方法
        private int GetMaxId()
        {
            string sql = "select max(id) as maxId from user";
            SqlConnection conn;
            string conStr = "Data Source=.;Database=User;Integrated Security=True";
            conn = new SqlConnection(conStr);
            conn.Open();

            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            int maxId = 0;
            if (reader.Read())
            {
                maxId = Convert.ToInt32(reader["maxId"]);
            }
            reader.Close();
            conn.Close();
            return maxId;
        }

        [Test]
        public void TestInsert()
        {
            User user = new User();

            User user2 = new User();
            user.Email = "2844013682@qq.com";
            user.Password = "3";
            user.Sex = "男";
            user.Nickname = "笛笛";
            user.Bithday = "1997-01-03 00:00:00.000";
            user.Regtime = "2015-01-03 00:00:00.000";

            //是否插入成功
            Assert.IsTrue(dbUser.Insert(user));
            int Maxid = this.GetMaxId();
            user.Id = Maxid;

            user2 = dbUser.GetById(Maxid);

            //比较
            Assert.AreEqual(user.Id, user2.Id);
            //做完测试删除
            dbUser.RemoveById(Maxid);
        }
        //更新测试
        //获取数据测试
        [Test]
        public void GetTest()
        {

            user user = new user();

            user user2 = new user();
            user.Email = "284401382@qq.com";
            user.Password = "3";
            user.Sex = "男";
            user.Nickname = "笛笛";
            user.Bithday = "1997-01-03 00:00:00.000";
            user.Regtime = "2015-01-03 00:00:00.000";

            //是否插入成功
            Assert.IsTrue(dbUser.Insert(user));
            int Maxid = this.GetMaxId();
            user.Id = Maxid;

            user2 = dbUser.GetById(Maxid);

            //比较
            Assert.AreEqual(user.Id, user2.Id);
            //做完测试删除
            dbUser.RemoveById(Maxid);

        }
        //删除测试
        [Test]
        public void DeleteTest()
        {
            user user = new user();
            user.Email = "284401382@qq.com";
            user.Password = "3";
            user.Sex = "男";
            user.Nickname = "笛笛";
            user.Bithday = "1997-01-03 00:00:00.000";
            user.Regtime = "2015-01-03 00:00:00.000";
            //是否插入成功
            Assert.IsTrue(dbUser.Insert(user));
            int Maxid = this.GetMaxId();
            dbUser.RemoveById(Maxid);
            user user2 = dbUser.GetById(Maxid);
            Assert.IsNull(user2);
        }
    }
}

