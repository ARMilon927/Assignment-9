using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabPracticeWithCustomer.Model;
using LabPracticeWithCustomer.Repository;
namespace LabPracticeWithCustomer.Manager
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();

        public List<string> GetAllDistrict()
        {
            return _customerRepository.GetAllDistrict();
        }

        public bool ExistCode(Customer customer)
        {
            return _customerRepository.ExistCode(customer);
        }

        public bool ExistContact(Customer customer)
        {
            return _customerRepository.ExistContact(customer);
        }

        public string InsertCustomer(Customer customer)
        {
            string message;
            message = _customerRepository.InsertCustomer(customer) > 0
                ? message = "Customer saved successfully"
                : message = "Customer can not saved";
            return message;
        }

        public List<Customer> ShowCustomer()
        {
            return _customerRepository.ShowCustomer();
        }

        public bool UpdateCustomer(Customer customer)
        {
            return _customerRepository.UpdateCustomer(customer);
        }
        public List<Customer> SearchCustomer(Customer customer)
        {
            return _customerRepository.SearchCustomer(customer);
        }
    }
    
}
