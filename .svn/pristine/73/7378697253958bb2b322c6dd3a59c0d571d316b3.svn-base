using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagarroSoftware.DotNet.Training.Week1Assignment2Question4
{
    class Program
    {
        /// <summary>
        /// Serves customer of organization by token based customer service system
        /// </summary>
        /// <param name="args">default arguements</param>
        static void Main(string[] args)
        {
            //a list to save customers added by user
            List<Customer> customers = new List<Customer>();

            Console.WriteLine("Enter your organization name(Example- Nagarro,Apollo,Haldirams)");
            string organizationName = Console.ReadLine();

            Console.WriteLine("Enter the number of counters for Customer Service:-");
            int counterCount;
            int.TryParse(Console.ReadLine(),out counterCount);

            //organization made by user 
            Organization organization = new Organization(organizationName, counterCount);
            Console.WriteLine("Enter customers for queue in customer service:-");

            char exitChoice = 'y'; // 'y' to continue and 'n' to exit
            string customerName;
            int intCustomerType;
            CustomerType customerType;
            Customer customer;
            
            while (exitChoice == 'y' || exitChoice == 'Y')
            {
                Console.WriteLine("Enter customer name");
                customerName = Console.ReadLine();

                Console.WriteLine("Enter customer type(0-for Privileged Customer , 1- Normal Customer)");
                int.TryParse(Console.ReadLine(),out intCustomerType);

                if (intCustomerType == 0)
                    customerType = CustomerType.Privileged;
                else
                    customerType = CustomerType.Normal;

                customer = new Customer(customerName, customerType);
                customers.Add(customer);

                Console.WriteLine("Do you want to enter more customers (Y/N) :- ");
                exitChoice = Convert.ToChar(Console.ReadLine());
            }
            //adding customers to organization
            organization.AddCustomer(customers);

            //calling method to serve customers by customer service
            organization.ServiceCustomer();

            Console.ReadLine();
        }
    }
}
