using System;
using System.Text;
using PracticesCsharp04Enum.Entities04.Enums;
using PracticesCsharp04Enum.Entities04;
using System.Globalization;

namespace PracticesCsharp03Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate and initiate classes first

            Console.WriteLine("-----Enter client data: -----");
            Console.Write("Name: ");
            string clientName = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("-----Enter order data: -----");
            Console.Write("Status: ");
            OrderStatusClass status = Enum.Parse<OrderStatusClass>(Console.ReadLine());

            ClientClass client = new ClientClass(clientName, email, birthDate);
            OrderClass order = new OrderClass(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                ProductClass product = new ProductClass(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItemClass orderItem = new OrderItemClass(quantity, price, product);

                order.AddItem(orderItem);
            }
            Console.WriteLine();
            Console.WriteLine("-----ORDER SUMMARY:-----");
            Console.WriteLine(order);

        }
    }

    
}