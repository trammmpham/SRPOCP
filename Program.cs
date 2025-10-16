using SRPOCP.Log;
using SRPOCP.Payment;
using SRPOCP.Shape;

namespace SRPOCP
{
    public class Program
    {
        static void Main(string[] args)
        {
            IShape shape = new Circle(5);

            Console.WriteLine($"Area of circle with radius {5} is {shape.Area()}");
            shape = new Square(4);
            Console.WriteLine($"Area of square with side {4} is {shape.Area()}");
            shape = new Square(5);
            Console.WriteLine($"Area of square with side {5} is {shape.Area()}");
            shape = new Square(5);
            Console.WriteLine($"Area of square with side {5} is {shape.Area()}");


            Console.WriteLine("--------------------------------");
            

            ILogger fileLogger = new FileLogger();
            Logger logger = new Logger(fileLogger);
            logger.Log("This is a log message to file.");

            ILogger logger1 = new DatabaseLogger();
            Logger logger2 = new Logger(logger1);
            logger2.Log("This is a log message to database.");

            Console.WriteLine("--------------------------------");

            //Payment processing
            Payment.IPaymentProcessor paymentProcessor = new Payment.MomoPayment();
            MomoPayment momoPayment = new MomoPayment();
            PaymentGateway paymentGateway = new PaymentGateway(momoPayment);
            paymentGateway.MakePayment(100.00m);
            PaymentGateway paymentGateway1 = new PaymentGateway(momoPayment);
            paymentGateway1.MakePayment(200.00m);
            Console.WriteLine("--------------------------------");



        }
    }
}
