
namespace OCP
{
    ////Before OCP

    ////public class PaymentProcessor
    ////{
    ////    public void ProcessPayment(string paymentType)
    ////    {
    ////        if (paymentType == "CreditCard")
    ////        {
    ////            // Process credit card payment
    ////        }
    ////        else if (paymentType == "PayPal")
    ////        {
    ////            // Process PayPal payment
    ////        }
    ////    }
    ////}
  
   

    class Program
    {
        static void Main(string[] args)
        {
            IPaymentMethod creditCardPayment = new CreditCardPayment();
            PaymentProcessor processor1 = new PaymentProcessor(creditCardPayment);
            processor1.ProcessPayment();

            IPaymentMethod payPalPayment = new PayPalPayment();
            PaymentProcessor processor2 = new PaymentProcessor(payPalPayment);
            processor2.ProcessPayment();

            IPaymentMethod bitcoinPayment = new BitcoinPayment();
            PaymentProcessor processor3 = new PaymentProcessor(bitcoinPayment);
            processor3.ProcessPayment();
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