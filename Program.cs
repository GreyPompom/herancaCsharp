using System;
using System.Collections.Generic;
using herancaCsharp.Entities;
using System.Globalization;
namespace herancaCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Enter the number of employees: ");
            int quant = int.Parse(Console.ReadLine());

            for(int i = 0; i < quant; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char YN =char.Parse( Console.ReadLine());
                while (YN != 'y' && YN != 'n')
                {
                    Console.WriteLine("Erro: Por favor, insira apenas 'y' ou 'n'.");
                    Console.Write("Outsourced (y/n)? ");
                    YN = char.Parse(Console.ReadLine());
                }
                Console.Write("Name: ");
                String name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double VPH = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (YN == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourceEmployee(name, hours, VPH, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, VPH));
                }
            }


            Console.WriteLine();
            Console.WriteLine("Payments: ");
            foreach( Employee emp in list)
            {
                Console.WriteLine(emp.Name + " -  $ "+emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
