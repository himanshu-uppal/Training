using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagarroSoftware.DotNet.Training.Week1Assignment2Question2
{
    /// <summary>
    /// User Class stores the name and id of the user.
    /// </summary>
    class User
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public static int UserCount {get;set;}

        
        public User(string name)
        {
            UserCount++;
            this.Id = UserCount;
            this.Name = name;
        }
       
        public override String ToString()
        {
            return this.Name ;
        }

    }
}
