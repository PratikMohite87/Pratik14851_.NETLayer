using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace DatBaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dissconected_Dept();
            //Connected_Emp();
            Console.WriteLine(validate("pratik", "pratik123"));
            Console.WriteLine("Hello World!");
        }

        static void Dissconected_Dept() 
        {
            SqlConnection con = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;Initial Catalog=MastekTraining;Integrated Security=True;");
            string query = "SELECT * FROM Dept";

            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "dept");

            foreach (DataRow row in ds.Tables["dept"].Rows)
            {
                Console.WriteLine(row["DeptNo"]+" "+row["dname"]+" "+row["loc"]);
            }
        }

        static void Connected_Emp() 
        {
            SqlConnection con = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;Initial Catalog=MastekTraining;Integrated Security=True;");
            string query = "SELECT * FROM emp";

            SqlCommand command = new SqlCommand(query, con);

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
                Console.WriteLine(reader["EmpNo"]);

            if (con.State == ConnectionState.Open)
                con.Close();
        }

        static string validate(string username, string password)
        {
            SqlConnection con = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;Initial Catalog=MastekTraining;Integrated Security=True;");
            string query = "SELECT * FROM userdata WHERE username = @username";

            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.AddWithValue("@username",username);


            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Close();
                string query2 = "SELECT * FROM userdata WHERE username = @username and userpassword = @password";

                SqlCommand command2 = new SqlCommand(query2, con);
                command2.Parameters.AddWithValue("@username", username);
                command2.Parameters.AddWithValue("@password", password);

                SqlDataReader reader2 = command2.ExecuteReader();

                if (reader2.HasRows)
                    return "Successfull";
                else
                    return "Incorrect Password";
            }
            else
                return "Not valid User";
        }
    }
}
