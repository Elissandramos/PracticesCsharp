
using System.Globalization;

namespace PracticesCsharp04Enum.Entities04

{
    class OrderItemClass
    {
        //# Properties
        public int Quantity { get; set; }
        public double Price { get; set; }
        public ProductClass Product { get; }

        //# Associative compositions
        public ProductClass product { get; set; }

        //# Constructors
        public OrderItemClass()
        {
        }

        public OrderItemClass(int quantity, double price, ProductClass product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
        //# Methods
        public double SubTotal() {

             double subtotal = Quantity* Price;   

            return subtotal;
        }
        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
