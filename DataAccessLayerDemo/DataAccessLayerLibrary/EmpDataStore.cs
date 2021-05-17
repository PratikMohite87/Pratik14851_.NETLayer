using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerLib
{
    public class EmpDataStore
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;

        public EmpDataStore(string connectionString)
        {
            connection = new SqlConnection(connectionString);
        }

        // get all employes data
        public List<Emp> GetAllEmps()
        {
            try
            {
                string sql = "SELECT * from emp";
                command = new SqlCommand(sql, connection);

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                reader = command.ExecuteReader();

                List<Emp> empList = new List<Emp>();

                while (reader.Read())
                {
                    Emp emp = new Emp();
                    emp.EmpNo = (int)reader["EMPNO"];       // reader names can be case-insensitive.
                    emp.EmpName = reader["ENAME"].ToString();
                    emp.HireDate = reader["HIREDATE"] as DateTime?;
                    /*if (Convert.IsDBNull(reader["HIREDATE"]))
                    {
                        emp.HireDate = null;
                    }
                    else
                    {
                        emp.HireDate = (DateTime)reader["HIREDATE"];
                    }*/

                    emp.Salary = reader["SAL"] as decimal?;
                    /*if (Convert.IsDBNull(reader["SAL"]))
                    {
                        emp.Salary = null;
                    }
                    else
                    {
                        emp.Salary = (decimal)reader["SAL"];
                    }*/

                    empList.Add(emp);

                }

                return empList;
            }
            catch (SqlException ex)
            {
                throw;
            }
            finally 
            {

            }
        }

        public Emp GetEmp(int EmpNo)
        {
            try
            {
                string sql = "SELECT * from EMP WHERE EMPNO=@EmpNo";
                command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("EmpNo", EmpNo);

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                reader = command.ExecuteReader();

                Emp emp = new Emp();

                if (reader.Read())
                {
                    emp.EmpNo = (int)reader["EMPNO"];
                    emp.EmpName = reader["ENAME"].ToString();
                    emp.HireDate = reader["HIREDATE"] as DateTime?;
                    emp.Salary = reader["SAL"] as decimal?;

                    return emp;
                }

                return emp;
            }
            catch (SqlException ex)
            {
                throw;
            }
            finally
            {
                
            }
        }

        public int AddEmp(Emp emp)
        {
            try
            {
                string sql = "INSERT INTO EMP (EMPNO, ENAME, HIREDATE, SAL) VALUES (@EmpNo, @Ename, @Hiredate, @Salary)";
                command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("EmpNo", emp.EmpNo);
                command.Parameters.AddWithValue("Ename", emp.EmpName);
                command.Parameters.AddWithValue("Hiredate", emp.HireDate);
                command.Parameters.AddWithValue("Salary", emp.Salary);

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                return command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw;
            }
            finally 
            {

            }
        }

        public int UpdateEmp(Emp emp)
        {
            try
            {
                string sql = "UPDATE EMP SET ENAME = @Ename, HIREDATE = @Hiredate, SAL = @Salary WHERE EMPNO = @EmpNo";
                command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("EmpNo", emp.EmpNo);
                command.Parameters.AddWithValue("Ename", emp.EmpName);
                command.Parameters.AddWithValue("Hiredate", emp.HireDate);
                command.Parameters.AddWithValue("Salary", emp.Salary);

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                return command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw;
            }
            finally
            { 
            }
        }

        public int DeleteEmp(int EmpNo)
        {
            try
            {
                string sql = "DELETE FROM EMP WHERE EMPNO = @EmpNo";
                command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("EmpNo", EmpNo);

                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                return command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw;
            }
            finally
            {
                
            }
        }
    }
}
