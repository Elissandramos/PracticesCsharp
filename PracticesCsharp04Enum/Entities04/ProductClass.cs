

namespace PracticesCsharp04Enum.Entities04
{
    class ProductClass
    {
        //# Properties
        public string Name { get; set; }
        public double Price { get; set; }

        //# Constructors
        public ProductClass()
        {
        }
        public ProductClass(string name, double price)
        {
            Name = name;
            Price = price;
        }

    }
}
