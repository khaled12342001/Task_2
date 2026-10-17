using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Task_2
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private decimal _Salary;
        public decimal Salary
        {
            get

            {
                return _Salary;
            }
            set
            {
                if (value <= 0)
                {

                    throw new Exception("error");
                }
                _Salary = value;
            }
        }
        public Employee (string name)
        {
            Id = Counter.IncreaseCount();
            Name = name;
            
        }
        public  abstract void DisplayInfo();
        public abstract decimal CalculateSalary();
       
    }
}

        

