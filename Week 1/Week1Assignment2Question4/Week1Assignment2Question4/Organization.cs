using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagarroSoftware.DotNet.Training.Week1Assignment2Question4
{
    /// <summary>
    /// This is the organization which have customer service for its customers.
    /// </summary>
    class Organization
    {
        private string name;
        private List<Customer> customers = new List<Customer>();
        private CustomerService customerService = null;

        public Organization(string name, int counterCount)
        {
            this.name = name;
            this.customerService = new CustomerService(counterCount);
        }
        /// <summary>
        /// This method adds a customer to the organization 
        /// </summary>
        /// <param name="customer">This is the customer object whhich is to be added in the organization</param>
        public void AddCustomer(Customer customer)
        {
            this.customers.Add(customer);

        }
        /// <summary>
        /// This method adds a bulk of customer in the organization mentione din the list
        /// </summary>
        /// <param name="customers">This is the list of the customers to be added</param>
        public void AddCustomer(List<Customer> customers)
        {
            this.customers.AddRange(customers);

        }
        public override string ToString()
        {
            return this.name;
        }

        public void PrintCustomers()
        {
            foreach(Customer customer in this.customers)
            {
                Console.WriteLine(customer);
            }
        }
        /// <summary>
        /// This method serves a single customer through customer service of the organization
        /// </summary>
        /// <param name="customer">This is the customer object which requests for the customer service</param>
        public void ServiceCustomer(Customer customer)
        {
            this.customerService.Serve(customer);
        }
        /// <summary>
        /// This method serves all the customer in the organization
        /// </summary>
        public void ServiceCustomer()
        {
            this.customerService.Serve(this.customers);
        }
    }
}
