using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPOCP.Payment
{
    public class MomoPayment : IPaymentProcessor 
    {
        public void ProcessPayment(decimal amount)
        {
            // Implementation for processing payment via Momo
            Console.WriteLine($"Processing Momo payment of amount: {amount}");
            // Add Momo-specific payment processing logic here
        }
    }
}
