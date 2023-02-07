using LoginApp.DataComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginApp.DataRepos
{
    public interface IUserModule
    {
        Customer ValidateUser(string emailAddress, string password);
        void RegisterCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
    }
    public class UserModule : IUserModule
    {
        private bool isValidEmail(string emailAddress)
        {
            var context = new Entities();
            var rec = context.Customers.SingleOrDefault(c => c.CustomerEmail == emailAddress);
            return rec == null;
        }
        public void RegisterCustomer(Customer customer)
        {
            var context = new Entities();
            if (isValidEmail(customer.CustomerEmail))
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Customer is already Registered, Please click on Forgot Password");
            }
        }

        public void UpdateCustomer(Customer customer)
        {
            var context = new Entities();
            var selected = context.Customers.FirstOrDefault(c => c.CstId == customer.CstId);
            if (isValidEmail(customer.CustomerEmail))
            {
                selected.CustomerEmail = customer.CustomerEmail;
                selected.Password = customer.Password;
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Email already Exits");
            }
        }

        public Customer ValidateUser(string emailAddress, string password)
        {
            var context = new Entities();
            var customer = context.Customers.SingleOrDefault(c => c.CustomerEmail == emailAddress && c.Password == password);
            if (customer == null)
            {
                throw new Exception("Login Failed");
            }
            return customer;
        }
    }
}