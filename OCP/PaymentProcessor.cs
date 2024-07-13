using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class PaymentProcessor
    {
        private readonly IPaymentMethod _paymentMethod;

        public PaymentProcessor(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void ProcessPayment()
        {
            _paymentMethod.ProcessPayment();
        }
    }
    public class CreditCardPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            // Process credit card payment
            Console.WriteLine("Processing credit card payment.");
        }
    }

    public class PayPalPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            // Process PayPal payment
            Console.WriteLine("Processing PayPal payment.");
        }
    }
    public class BitcoinPayment : IPaymentMethod
    {
        public void ProcessPayment()
        {
            // Process Bitcoin payment
            Console.WriteLine("Processing Bitcoin payment.");
        }
    }
}
