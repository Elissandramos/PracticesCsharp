
using PracticesCsharp04Enum.Entities04.Enums;
using System.Text;
using System.Globalization;

namespace PracticesCsharp04Enum.Entities04
{
    class OrderClass
    {
        //# Properties
        public DateTime Moment { get; set; }
        public OrderStatusClass Status { get; set; }

        //# Associative compositions
        public ClientClass Client { get; set; }

        public List<OrderItemClass> items { get; set; } = new List<OrderItemClass>();

        //# Constructors
        public OrderClass(DateTime moment, OrderStatusClass status, ClientClass client)
        {
            Moment = moment;
            Status = status;
            Client = client;                
        }

        //# Methods
        public void AddItem(OrderItemClass item)
        {
            items.Add(item);
        }
        public void RemoveItem(OrderItemClass item)
        {
            items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItemClass item in items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItemClass item in items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();



        }
    }
}
