using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProduct
{
    internal class Users
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public bool IsAdmin { get; set; }
    }

    internal class UserDataBase
    {
        const string conString = "server=(LocalDb)\\MSSQLLocalDB;database=ProductDataBase;trusted_connection=true;";
        SqlConnection conn = new SqlConnection(conString);

        public void DbConnect()
        {
            conn.Open();
        }

        public void DbClose()
        {
            conn.Close();
        }

        public List<Users> GetUsers()
        {
            DbConnect();
            List<Users> userList = new List<Users>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM UserDB", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Users user = new Users()
                {
                    Id = Convert.ToInt32(dr["UserId"]),
                    UserName = Convert.ToString(dr["UserName"]),
                    Password = Convert.ToString(dr["Password"]),
                    IsAdmin = Convert.ToBoolean(dr["IsAdmin"])
                };
                userList.Add(user);
            }

            dr.Close();
            cmd.Dispose();
            DbClose();
            return userList;
        }

        public bool LoginTry(string userName, string password)
        {
            DbConnect();
            bool sonuc = false;
            SqlCommand cmd = new SqlCommand("SELECT 1 FROM UserDB WHERE UserName=@userName AND Password=@password",
                conn);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                if (dr.Read())
                {
                    sonuc = true;
                }
                else
                {
                    sonuc = false;
                }
            }

            cmd.Dispose();
            dr.Close();
            DbClose();
            return sonuc;
        }

        public bool CheckAdmin(string userName, string password)
        {
            DbConnect();
            bool adminsonuc = false;
            SqlCommand cmd =
                new SqlCommand("SELECT 1 FROM UserDB WHERE UserName=@userName AND Password=@password AND IsAdmin=1",
                    conn);
            cmd.Parameters.AddWithValue("@userName", userName);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                if (dr.Read())
                {
                    adminsonuc = true;
                }
                else
                {
                    adminsonuc = false;
                }
            }

            cmd.Dispose();
            dr.Close();
            DbClose();
            return adminsonuc;
        }

        public void AddUser(string username, string password, bool admin)
        {
            DbConnect();
            SqlCommand cmd =
                new SqlCommand("INSERT INTO UserDB (UserName,Password,IsAdmin) VALUES (@username,@password,@admin)",
                    conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@admin", admin);
        }

        public void UpdateUser(string username, string password, bool admin,int currentId)
        {
            DbConnect();
            SqlCommand cmd = new SqlCommand("UPDATE UserDB SET UserName=@username,Password=@password,IsAdmin=@admin where UserId=@id",
                conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@admin", admin);
            cmd.Parameters.AddWithValue("@id", currentId);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            DbClose();

        }

        public void DeleteUser(int currentID)
        {
            DbConnect();
            SqlCommand cmd = new SqlCommand("DELETE FROM UserDB WHERE UserId = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", currentID);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            DbClose();
        }
    }
}
