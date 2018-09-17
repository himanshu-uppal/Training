using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagarroSoftware.DotNet.Training.Week1Assignment2Question4
{
    /// <summary>
    /// This class shows the customer attributes of any organization
    /// </summary>
    class Customer 
    {    
        public string Name { get; set; }
        public CustomerType CustomerType { get; set; }
        public int Id { get; set; }
        public static int CustomerCount { get; set; }

        static Customer()
        {
            CustomerCount = 0;
        }

        public Customer(string name, CustomerType customerType)
        {
            CustomerCount++;
            this.Id = Customer.CustomerCount;
            this.Name = name;
            this.CustomerType = customerType;
        }

        public override string ToString()
        {
            return this.Name;
        }

       
    }
}
