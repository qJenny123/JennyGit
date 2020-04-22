using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;



namespace DataBase
{
    public class DataBase 
    {
        string conStr;
        DataBase conn;
        //插入操作
        public void Insert(User user)
        {
            //定义插入的sql语句
            conStr = "Data Source=.;Database=User;Integrated Security=True";       
            string sql = "insert into user(email,password,sex,nickname,birthday,regtime) values(@email,@password,@sex,@nickname,@birthday,@regname)";
            SqlConnection conn = ConnectionState.GetConnection();
            conn.Open();
            SqlCommand command = new SqlCommand(sql,conn);
            //****
            //command.Parameters.Add(new SqlParameter("@id",SqlDbType.Int));
            command.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar));
            command.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar));
            command.Parameters.Add(new SqlParameter("@sex", SqlDbType.VarChar));
            command.Parameters.Add(new SqlParameter("@nickname", SqlDbType.VarChar));
            command.Parameters.Add(new SqlParameter("@birthday", SqlDbType.DateTime));
            command.Parameters.Add(new SqlParameter("@regname", SqlDbType.DateTime));

            //****
           // command.Parameters["@id"].Value = user.Id;
            command.Parameters["@email"].Value = user.Email;
            command.Parameters["@password"].Value = user.Password;
            command.Parameters["@sex"].Value = user.Sex;
            command.Parameters["@nickname"].Value = user.Nickname;
            command.Parameters["@birthday"].Value = user.Bithday;
            command.Parameters["@regname"].Value = user.Regtime;
            try
            {
               command.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                conn.Close();
            }

        }

        //根据用户id查询信息的操作
        public User GetById(int id)
        {
            string sql = "select * from user where id =@id";
            conStr = "Data Source=.;Database=User;Integrated Security=True";
            SqlConnection conn = ConnectionState.GetConnection();

            conn.Open();
            SqlCommand command = new SqlCommand(sql,conn);
            command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            command.Parameters["@id"].Value = id;
            
            SqlDataReader reader = command.ExecuteReader();
            User user = null;

              if (reader.Read())
             {
                   user = new user();
    
                   user.Id = id;
                   user.Email = reader["email"].ToString();
                   user.Password = reader["password"].ToString();
                   user.Nickname = reader["nickname"].ToString() ;
                   user.Bithday =  reader["birthday"].ToString();
                   user.Regtime = reader["regtime"].ToString();
                   user.Sex = reader["sex"].ToString(); 
                  //user.Sex = Convert.ToInt32(reader["age"]);
               }
    
               reader.Close();
               conn.Close();
    
               return user;
        }
        //删除用户通过id
        public void  RemoveById(int id)
        {
            string sql = "delete from user where id = @id";
            conStr = "Data Source=.;Database=User;Integrated Security=True";
            SqlConnection conn = Connection.GetConnection();
            conn.Open();

            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
            command.Parameters["@id"].Value = id;
            try
            {
                command.ExecuteNonQuery();
                }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
           
        }
    }
}
