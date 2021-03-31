using SnurrtumlareWebSite.Data;
using SnurrtumlareWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnurrtumlareWebSite.Services
{
    public class CustomersService
    {

        public List<Customer> Customers { get; set; }

        DummyData dummyData = new DummyData();

        public CustomersService()
        {
            Customers = dummyData.TempCustomers;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return dummyData.TempCustomers;
        }

        public IEnumerable<Customer> GetCustomer(int id)
        {
            return Customers.Where(c => c.CustomerId == id).ToList();
        }
        
        public void CreateCustomer(int customerId, string firstName, string lastName, string address, string zipCode, string city, string email, string phone)
        {
            Customers.Add(new Customer
            { CustomerId = customerId, FirstName = firstName, LastName = lastName, Address = address, ZipCode = zipCode, City = city, Email = email, Phone = phone });
        }

        public void EditCustomer(int id, string firstName, string lastName, string address, string zipCode, string city, string email, string phone)
        {
            Customers = Customers.Where(c => c.CustomerId == id).ToList();
            
            Customers[0].FirstName = firstName;           
            Customers[0].LastName = lastName;           
            Customers[0].Address = address;           
            Customers[0].ZipCode = zipCode;           
            Customers[0].City = city;           
            Customers[0].Email = email;           
            Customers[0].Phone = phone;           
        }

        public void DeleteCustomer(int id)
        {
            Customers.RemoveAll(c => c.CustomerId == id);
        }

    }
}
