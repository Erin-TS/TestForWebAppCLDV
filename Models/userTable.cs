using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace TestForWebAppCLDV.Models
{
    public class userTable 
    {
        public static string con_string ="Server=tcp:clouddev-sql-sever.database.windows.net,1433;Initial Catalog=clouddev-sql-database;Persist Security Info=False;User ID=Erin;Password=J@ckEr!n2003;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30";
        public static SqlConnection con = new SqlConnection(con_string);

        public String Name {  get; set; }

        public  String Surname { get; set; }
        public String Email { get; set; }

        public int insert_User(userTable a)
        {
           
                string sql = "INSERT INTO userTable (UserName, UserSurname, UserEmail) VALUES (@Name, @Surname,@Email)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", a.Name);
                cmd.Parameters.AddWithValue("@Surname", a.Surname);
                cmd.Parameters.AddWithValue("@Email", a.Email);
                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                return rowsAffected;
           
        }
       
    }
}
