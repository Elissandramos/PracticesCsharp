
namespace PracticesCsharp02Enum.Entities02
{
    class HourContractClass
    {
        // # Properties
        public DateTime Date { get; set; }

        public double ValuePerHour { get; set; }

        public int Hours { get; set; }

        // # Constructors
        public HourContractClass()
        {
        }

        public HourContractClass(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        // # Methods
        public double TotalValue() 
        { 
            return Hours * ValuePerHour;
        } 



    }
}
