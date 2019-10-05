using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabPracticeWithCustomer.Model;
namespace LabPracticeWithCustomer.Repository
{
    public class CustomerRepository
    {
        string connectionString = @"Server=.\SILENTREVENGER; Database=LabPracticeDb; Integrated Security=True";
        private SqlConnection sqlConnection;
        private string commandString;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlDataAdapter;
        private SqlDataReader reader;
        
        List<string> districts = new List<string>();

        public List<string> GetAllDistrict()
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT * FROM Locations";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                string district;
                district = reader["District"].ToString();
                districts.Add(district);
            }
            return districts;
        }
        public bool ExistCode(Customer customer)
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT * FROM Customers WHERE Code = '" + customer.Code + "' AND Id <>" + customer.Id + "";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            reader = sqlCommand.ExecuteReader();
            bool isExist = reader.HasRows;
            reader.Close();
            sqlConnection.Close();
            return isExist;
        }
        public bool ExistContact(Customer customer)
        {
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT * FROM Customers WHERE Contact = '" + customer.Contact + "' AND Id <>" + customer.Id + "";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            reader = sqlCommand.ExecuteReader();
            bool isExist = reader.HasRows;
            reader.Close();
            sqlConnection.Close();
            return isExist;
        }
        public int InsertCustomer(Customer customer)
        {

            sqlConnection = new SqlConnection(connectionString);
            commandString = @"INSERT INTO Customers (Code, Name, Address, Contact, District) Values ('" + customer.Code + "', '" + customer.Name + "', '" + customer.Address + "', '" + customer.Contact + "', '" + customer.District + "')";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isExecuted = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return isExecuted;
        }
        public List<Customer> ShowCustomer()
        {
            List<Customer> customers = new List<Customer>();
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT * FROM Customers";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Customer aCustomer = new Customer();
                aCustomer.Id = Convert.ToInt16(reader["Id"]);
                aCustomer.Code = reader["Code"].ToString();
                aCustomer.Name = reader["Name"].ToString();
                aCustomer.Address = reader["Address"].ToString();
                aCustomer.Contact = reader["Contact"].ToString();
                aCustomer.District = reader["District"].ToString();
                customers.Add(aCustomer);
            }
            sqlConnection.Close();
            return customers;
        }

        public bool UpdateCustomer(Customer customer)
        {
            bool rowAffected = false;
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                commandString = @"UPDATE Customers SET Name = '" + customer.Name + "', Contact = '" + customer.Contact + "', Address = '" + customer.Address + "', Code = '"+customer.Code+"', District = '"+ customer.District+"' WHERE Id = " + customer.Id + "";
                sqlCommand = new SqlCommand(commandString, sqlConnection);
                sqlConnection.Open();
                int isExecuted = sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                if (isExecuted > 0)
                    rowAffected = true;
            }
            catch (Exception e)
            {
                rowAffected = false;
            }
            return rowAffected;
        }
        public List<Customer> SearchCustomer(Customer customer)
        {
            List<Customer> customers = new List<Customer>();
            sqlConnection = new SqlConnection(connectionString);
            commandString = @"SELECT * FROM Customers WHERE Name = '" + customer.Name + "' OR Contact = '" + customer.Contact + "' OR Address = '" + customer.Address + "' OR Code = '" + customer.Code + "' OR District = '" + customer.District + "' ";
            sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Customer aCustomer = new Customer();
                aCustomer.Id = Convert.ToInt16(reader["Id"]);
                aCustomer.Code = reader["Code"].ToString();
                aCustomer.Name = reader["Name"].ToString();
                aCustomer.Address = reader["Address"].ToString();
                aCustomer.Contact = reader["Contact"].ToString();
                aCustomer.District = reader["District"].ToString();
                customers.Add(aCustomer);
            }
            sqlConnection.Close();
            return customers;
        }
    }
}
