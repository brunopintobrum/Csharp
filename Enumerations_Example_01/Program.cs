using Enumerations_Example_01.Entities;
using Enumerations_Example_01.Entities.Enums;
using System;

namespace Enumerations_Example_01
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            
            // Converting format Enum --> String
            string txt = OrderStatus.PendingPayment.ToString();

            // Conversion inverse string --> enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);
            

        }
    }
}
