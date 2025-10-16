using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPOCP.Payment
{
    public class PaymentGateway
    { 
        private readonly IPaymentProcessor _paymentProcessor;
        public PaymentGateway(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }
        public void MakePayment(decimal amount)
        {
            _paymentProcessor.ProcessPayment(amount);
        }

    }
}
