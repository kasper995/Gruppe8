using System;
using System.Data.SqlClient;

namespace Logic
{
    public class Employee
    {
        private readonly SqlConnection _con;
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Initialer { get; set; }

        public Void Create()
        {
            string query = @"
            INSERT INTO dbo.Employees (Initials, FirstName, LastName) 
            VALUES (@Initials, @FirstName, @LastName)
            ";
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, _con))
                {
                    _con.Open();

                    cmd.Parameters.Add(new SqlParameter("@Initials", employee.Initials));
                    cmd.Parameters.Add(new SqlParameter("@FirstName", employee.FirstName));
                    cmd.Parameters.Add(new SqlParameter("@LastName", employee.LastName));

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _con.Close();
            }
            
        }
        public Void Update()
        {

        }
        public Void Delete()
        {

        }
    }
}