using System;
using System.Globalization;
using PracticesCsharp02Enum.Entities02.Enums;
using PracticesCsharp02Enum.Entities02;

namespace PracticesCsharp02Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler os dados de um trabalhador com N contratos(N fornecido pelo usuário).Depois, solicitar
            //do usuário um mês e mostrar qual foi o salário do funcionário nesse mês.
            // section 09 - Udemy class

            //get the user's inputs - part01

            Console.Write("Enter department's name: ");            
            string deptName = Console.ReadLine();
            Console.WriteLine("---------Enter worker data: ---------");
            //Console.Write();

            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevelClass level = Enum.Parse<WorkerLevelClass>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //instantiate objects with the user's inputs 
            DepartmentClass dept = new DepartmentClass(deptName);
            WorkerClass worker = new WorkerClass(name, level, baseSalary, dept);

            //get the user's inputs - part02
            Console.Write("How many contracts this worker have? ");
            int n = int.Parse(Console.ReadLine());

            for (int i =1; i <= n; i++) 
            {
                Console.Write($"-------Enter {i} contract data: ----------");
                Console.WriteLine();
                Console.Write("Date (DD/MM/YYYY):");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour:");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                //instantiate objects with the user's inputs
                HourContractClass contract = new HourContractClass(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine("-------------------------------------------------");
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");           
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("--------------------Results----------------------");
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month));

        }

    }
}


