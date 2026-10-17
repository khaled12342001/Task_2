using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2
{
    public class FullTimeEmployee : Employee, IWorkable
    {
       
        public FullTimeEmployee( string name, decimal salary) : base( name)
        {
            Salary=salary;
         }

       
      
        public override void DisplayInfo()
        {
            Console.WriteLine($"Id:{Id} Name:{Name}");
                
            Console.WriteLine("Employee Type: Full-Time");
            Console.WriteLine($"Salary: {CalculateSalary()}");
        }
        public override decimal CalculateSalary()
        {
            return Salary;
        }
        public void Work()
        {
            Console.WriteLine($"{Name} is working full-time.");

        }




    }
}
