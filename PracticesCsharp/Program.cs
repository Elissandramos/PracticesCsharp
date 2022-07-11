using PracticesCsharp01Enum.Entities;
using PracticesCsharp01Enum.Entities.Enums;
using System;

namespace PracticesCsharp01Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate and initiate (decide the values)
            Order order = new Order(1080, DateTime.Now, OrderStatus.PendingPayment);

            //iniate with the constructor (1080, DateTime.Now, OrderStatus.PedingPayment);

            //or this way
            //Order order = new Order
            // { 
            //    Id = 1080,
            //    Moment = DateTime.Now,
            //    Status = OrderStatus.PendingPayment
            // };

            Console.WriteLine("------> " + order);

            // converting enum to string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine("------> "+txt);

            // converting string to enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine("------> "+os);
        }

    }
}

