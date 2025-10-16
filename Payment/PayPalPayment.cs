using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPOCP.Payment
{
    public class PayPalPayment : IPaymentProcessor 
    {
        public void ProcessPayment(decimal amount)
        {
            
            Console.WriteLine($"Processing PayPal payment of amount: {amount}");
            // Add PayPal-specific payment processing logic here 
        }
    }
}
