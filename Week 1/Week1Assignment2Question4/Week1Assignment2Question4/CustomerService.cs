using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagarroSoftware.DotNet.Training.Week1Assignment2Question4
{
    /// <summary>
    /// This class shows the Customer service details for any organization
    /// </summary>
    class CustomerService
    {

        public List<Counter> Counters { get; set; }
        private PriorityQueue<Token> tokens = new PriorityQueue<Token>();
        public int TokenCount { get; set; }        

        public CustomerService(int counterCount)
        {            
            this.Counters = new List<Counter>(counterCount);
            for(int i = 0; i < counterCount; i++)
            {
                Counter counter = new Counter("Counter-"+(i+1));
                this.Counters.Add(counter);
            }

        }
        /// <summary>
        /// This method serves a single cutomer for the token based customer service 
        /// </summary>
        /// <param name="customer">This is the customer object who requested the service</param>
        public void Serve(Customer customer)
        {
            Token token = new Token(customer);
            this.tokens.Enqueue(token); 
            
            ServeAtCounter();          

        }
        /// <summary>
        /// This method serves a number of cutomers for the token based customer service 
        /// </summary>
        /// <param name="customers">This is the List of customer's object who requested the service</param>
        public void Serve(List<Customer> customers)
        {
            foreach(Customer customer in customers)
            {
                Token token = new Token(customer);
                this.tokens.Enqueue(token);  
            }
            ServeAtCounter();
        }
        /// <summary>
        /// This method serves the customer on the basis of type of customer and token of the customer.
        /// </summary>
        private void ServeAtCounter()
        {                   
            while (this.tokens.Count>0)
            {
                Token token = tokens.Peek(); //fetch from priority queue
                
                Counter freeCounter = GetFreeCounter();            
                Console.WriteLine("Serving- {0} [{1} Customer] at {2} with token no.- {3}",token.Customer.Name,token.Customer.CustomerType,freeCounter.Name,token.TokenNumber);
                this.tokens.Dequeue();
                MakeCounterBusy(freeCounter);
                                
            }
        }
        
        /// <summary>
        /// This methods returns the free counter which is ready to serve a customer
        /// </summary>
        /// <returns>This is the counter object which is free. </returns>
        private Counter GetFreeCounter()
        {
            Counter freeCounter = null;
            while(freeCounter == null)
            {
                foreach (Counter counter in this.Counters)
                {
                    if (counter.IsOccupied == false)
                    {
                        freeCounter = counter;
                        break;
                    }

                }
                if(freeCounter == null)
                {
                    foreach (Counter counter in this.Counters)
                    {
                        int diff = (DateTime.Now -counter.LastTokenTime).Seconds;

                        if (diff > 1)
                        {
                            
                            counter.IsOccupied = false;
                            freeCounter = counter;
                            break;

                        }
                    }

                }               
                
            }              

            return freeCounter;            
        }
        /// <summary>
        /// This method makes the counter busy.
        /// </summary>
        /// <param name="counter">The counter object which has to be made busy.</param>
        private void MakeCounterBusy(Counter counter)
        {
            counter.IsOccupied = true;
            counter.LastTokenTime = DateTime.Now;
        }


    }
}
