using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Customer
    {
        public string Id { get; private set; }
        public int ServiceDuration { get; private set; }
        public decimal Profit { get; private set; }

        public Customer(string id, int serviceDuration, decimal profit)
        {
            Id = id;
            ServiceDuration = serviceDuration;
            Profit = profit;
        }
        
    }
}
