using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagarroSoftware.DotNet.Training.Week1Assignment2Question4
{
    /// <summary>
    /// This class denotes the Counter for the customer service of any organization.
    /// </summary>
    class Counter
    {
        public string Name { get; set; }
        public bool IsOccupied { get; set; }
        public DateTime LastTokenTime { get; set; }

        public Counter(string name)
        {
            this.Name = name;
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
}
