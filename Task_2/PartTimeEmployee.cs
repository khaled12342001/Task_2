using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public class PartTimeEmployee:Employee, IWorkable
    {
        public int Hour {  get; set; }
        public decimal HourlyRate {  get; set;}

        public PartTimeEmployee( string name, int hour,decimal hourlyrate) : base( name)
        {
            Hour = hour;
            HourlyRate = hourlyrate;
        }



        public override void DisplayInfo()
        {
            
             Console.WriteLine($"Id:{Id} Name:{Name}");
             Console.WriteLine("Employee Type: Part-Time");
             Console.WriteLine($"Salary: {CalculateSalary()}");
        }
        public override decimal CalculateSalary()
        {
            Salary = Hour * HourlyRate;
            return Salary;
            
        }
        public void Work()
        {
            Console.WriteLine($"{Name} is working part-time.");

        }




    }
}
