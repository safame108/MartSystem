using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuisnessObject;
using System.Configuration;

namespace DataAccess
{
  public class EmployeeDAL
    {
        SqlConnection conn;
        SqlCommand cmd;
     
        public EmployeeDAL() {

        }

        public void AddEmployee(EmployeeBO E,EmployeeDetails ED,SignUp Signup) {
            using (conn = new SqlConnection(@"Data Source=ADMINRG-V7F0M8L;Initial Catalog=MartSystem;Integrated Security=True"))
            {
                conn.Open();
                String Query1 = "INSERT INTO Employees VALUES(@id,@First,@Last,@contact,@address,@hire,@account)";
                cmd = new SqlCommand(Query1, conn);
                cmd.Parameters.Add("@id", E.EmployeeID);
                cmd.Parameters.Add("@First", E.FirstName);
                cmd.Parameters.Add("@Last", E.LastName);
                cmd.Parameters.Add("@contact", E.ContactNumber);
                cmd.Parameters.Add("@address", E.Address);
                cmd.Parameters.Add("@hire", E.HireDate);
                cmd.Parameters.Add("@account", E.AccNumber);
                cmd.ExecuteNonQuery();

                String Query2 = "INSERT INTO Employees_Details VALUES(@id,@jobid,@branch,@dept)";
                cmd = new SqlCommand(Query2, conn);
                cmd.Parameters.Add("@jobid", ED.Job_ID);
                cmd.Parameters.Add("@branch", ED.Branch_ID);
                cmd.Parameters.Add("@dept", ED.Department_ID);
                cmd.Parameters.Add("@id", ED.Employee_ID);
               
                cmd.ExecuteNonQuery();
                String Query3 = "INSERT INTO LogIn_Details VALUES(@name,@id,@password,@email)";
                cmd = new SqlCommand(Query3, conn);
                cmd.Parameters.Add("@id", Signup.ID);
                cmd.Parameters.Add("@name",Signup.Username);
                cmd.Parameters.Add("@password", Signup.Password);
                cmd.Parameters.Add("@email", Signup.Email);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void RemoveEmployee(EmployeeBO E) {
            using (conn = new SqlConnection(@"Data Source=ADMINRG-V7F0M8L;Initial Catalog=MartSystem;Integrated Security=True"))
            {
                conn.Open();
                String Query = "DELETE FROM Employees WHERE Employee_ID = @id";
                cmd = new SqlCommand(Query, conn);
                cmd.Parameters.Add("@id", E.EmployeeID);
               
                cmd.ExecuteNonQuery();
                String Query1 = "DELETE FROM Employees_Details WHERE Employee_ID = @id";
                cmd = new SqlCommand(Query1, conn);
                cmd.Parameters.Add("@id", E.EmployeeID);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        public EmployeeBO UpdateEmployee(EmployeeBO E) {
            using (conn = new SqlConnection(@"Data Source=ADMINRG-V7F0M8L;Initial Catalog=MartSystem;Integrated Security=True"))
            {
                conn.Open();
                String Query = "UPDATE Employees SET First_Name = @First , Last_Name = @Last , Contact_Number = @contact , Address = @address , Hire_Date = @hire , Account_Number = @account WHERE Employee_ID = @id";
                cmd = new SqlCommand(Query, conn);
                cmd.Parameters.Add("@id", E.EmployeeID);
                cmd.Parameters.Add("@First", E.FirstName);
                cmd.Parameters.Add("@Last", E.LastName);
                cmd.Parameters.Add("@contact", E.ContactNumber);
                cmd.Parameters.Add("@address", E.Address);
                cmd.Parameters.Add("@hire", E.HireDate);
                cmd.Parameters.Add("@account", E.AccNumber);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            return E;
        }
        public EmployeeBO RetrieveEmployeeInfo(int id)
        {
            EmployeeBO E = new EmployeeBO();
            E.EmployeeID = id;
            using (conn = new SqlConnection(@"Data Source=ADMINRG-V7F0M8L;Initial Catalog=MartSystem;Integrated Security=True"))
            {
                conn.Open();
                String Query = "SELECT * FROM Employees WHERE Employee_ID = @id";
                cmd = new SqlCommand(Query, conn);
                cmd.Parameters.Add("@id", id);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        E.FirstName= reader["First_Name"].ToString();
                        E.LastName = reader["Last_Name"].ToString();
                        E.ContactNumber = reader["Contact_Number"].ToString();
                        E.Address = reader["Address"].ToString();
                        E.HireDate = reader["Hire_Date"].ToString();
                        E.AccNumber = reader["Account_Number"].ToString();
                    }
                }

                cmd.ExecuteNonQuery();
                conn.Close();
            }

            return E;
        }
        public SqlDataAdapter RetrieveEmployeeInfo(string name)
        {
            EmployeeBO E = new EmployeeBO();
            E.FirstName = name;
     
            conn = new SqlConnection(@"Data Source=ADMINRG-V7F0M8L;Initial Catalog=MartSystem;Integrated Security=True");

            conn.Open();
            String Query = "SELECT * FROM Employees WHERE First_Name LIKE '%" + name + "%'";
            SqlDataAdapter sqa = new SqlDataAdapter(Query, conn);
            return sqa;

        }

        private EmployeeDetails EmployeeWorkPropertiesIDs(EmployeeBO E){
            EmployeeDetails ED = new EmployeeDetails();
            ED.Employee_ID = E.EmployeeID;
            using (conn = new SqlConnection(@"Data Source=ADMINRG-V7F0M8L;Initial Catalog=MartSystem;Integrated Security=True"))
            {
                conn.Open();
                String Query = "SELECT * FROM Employees_Details WHERE Employee_ID = @id";
                cmd = new SqlCommand(Query, conn);
                cmd.Parameters.Add("@id", E.EmployeeID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ED.Job_ID = Convert.ToInt32(reader["Job_ID"].ToString());
                        ED.Branch_ID = Convert.ToInt32(reader["Branch_ID"].ToString());
                        ED.Department_ID = Convert.ToInt32(reader["Department_ID"].ToString());

                    }
                }

                cmd.ExecuteNonQuery();
                conn.Close();
            }
            return ED;
        }
        /// Proper Names
        public WorkProperties EmployeeWorkProperties(EmployeeBO E) {
            EmployeeDetails ED = EmployeeWorkPropertiesIDs(E);
            WorkProperties WP = new WorkProperties();
            using (conn = new SqlConnection(@"Data Source=ADMINRG-V7F0M8L;Initial Catalog=MartSystem;Integrated Security=True"))
            {
                conn.Open();
                //JOB
                String Query1 = "SELECT * FROM Jobs WHERE Job_ID = @id";
                cmd = new SqlCommand(Query1, conn);
                cmd.Parameters.Add("@id", ED.Job_ID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        WP.Position = reader["Position"].ToString();
                        WP.Salary = reader["Salary"].ToString();
                       
                    }
                }
                cmd.ExecuteNonQuery();
                //BRANCH
                String Query2 = "SELECT * FROM Branch WHERE Branch_ID = @id";
                cmd = new SqlCommand(Query2, conn);
                cmd.Parameters.Add("@id", ED.Branch_ID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        WP.Branch_Address = reader["Branch_Address"].ToString();
                        WP.ContactNumberBranch = reader["Contact_Number"].ToString();
                        WP.CityBranch = reader["City"].ToString();

                    }
                }
                cmd.ExecuteNonQuery();
                ///deprt
                 //BRANCH
                String Query3= "SELECT * FROM Department WHERE Department_No = @id";
                cmd = new SqlCommand(Query3, conn);
                cmd.Parameters.Add("@id", ED.Department_ID);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        WP.DepartmentName = reader["Department_Name"].ToString();

                    }
                }
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            return WP;
        }
        public SqlDataAdapter ShowEmployeeList()
        {

            conn = new SqlConnection(@"Data Source=ADMINRG-V7F0M8L;Initial Catalog=MartSystem;Integrated Security=True");
            
                conn.Open();
                String Query = "SELECT * FROM Employees";
                SqlDataAdapter sqa = new SqlDataAdapter(Query, conn);
                return sqa;
            
        }
    }
}
