using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPAY.Model
{
    public class TransactionHistory
    {
        public string Id { get; set; }

        public string AmountWithdrawn { get; set; }

        public string AmountDeposited { get; set; }

        public DateTime TimeInitiated { get; set; }

        public string Status { get; set; }  

        public string Narration { get; set; }

        public TransactionHistory() 
        {
            TimeInitiated = DateTime.Now;
        }
    }
}
