using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagarroSoftware.DotNet.Training.Week1Assignment2Question4
{
    /// <summary>
    /// This class represents the token assigned to each customer for the customer service in the organization
    /// </summary>
    class Token : IComparable<Token>
    {
        public int TokenNumber { get; set; }
        public DateTime TimeAssigned { get; set; }
        public Customer Customer { get; set; }
        public static int TokenCount { get; set; }
        static Token()
        {
            TokenCount = 0;
        }

        public Token(Customer customer)
        {
            TokenCount++;
            this.TokenNumber = TokenCount;
            this.TimeAssigned = DateTime.Now;
            this.Customer = customer;

        }
        public override string ToString()
        {
            return TokenNumber.ToString();
        }
        /// <summary>
        /// This method compares two tokens on the basis of their customer type and token number
        /// </summary>
        /// <param name="otherToKen">This is the token which is compared.</param>
        /// <returns></returns>
        public int CompareTo(Token otherToKen)
        {
            int result = 0;

            if(this.Customer.CustomerType != otherToKen.Customer.CustomerType)
            {
                if (this.Customer.CustomerType == 0)
                    result = 1;
                else
                    result = -1;
            }
            else
            {
                if (this.TokenNumber < otherToKen.TokenNumber)
                    result = 1;
                else
                    result = -1;
            }
            return result;

            
        }

    }
}
