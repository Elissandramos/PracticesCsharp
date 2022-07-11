
using PracticesCsharp02Enum.Entities02.Enums;

namespace PracticesCsharp02Enum.Entities02
{
    class WorkerClass
    {
        // # Properties
        public string Name { get; set; }

        public WorkerLevelClass Level { get; set; }

        public double BaseSalary { get; set; }

        // associate compositions (check the arrow assocition in the diagram)
        public DepartmentClass Department { get; set; }

        public List<HourContractClass> Contracts { get; set; } = new List<HourContractClass>();

        // # Constructors
        public WorkerClass()
        {
        }
        public WorkerClass(string name, WorkerLevelClass level, double baseSalary, DepartmentClass department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        // # Methods
        public void AddContract(HourContractClass contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContracts(HourContractClass contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContractClass contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum; 
        }

    }
}
