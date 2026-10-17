using Task_2;
string choose;
do
{
    Employee employee;
    Console.WriteLine("enter your name");
    string name = Console.ReadLine();
    Console.WriteLine("enter your EmployeeType : FullTime  or PartTime");
    string EmployeeType = Console.ReadLine();
    if (EmployeeType == "FullTime")

    {
        Console.WriteLine("enter your Salary");
        decimal Salary = Convert.ToDecimal(Console.ReadLine());

        employee = new FullTimeEmployee(name, Salary);
    }
    else if (EmployeeType == "PartTime")
    {
        Console.WriteLine("enter your CountHour");
        int CountHoure = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("enter your HourlyRate");
        decimal HourlyRate = Convert.ToDecimal(Console.ReadLine());
        employee = new PartTimeEmployee(name, CountHoure, HourlyRate);


    }

    else
    {
        throw new Exception();
    }
    employee.DisplayInfo();
    IWorkable workable = (IWorkable)employee;
    workable.Work();
    Console.WriteLine("Do you want to add another employee? (yes/no)");
    choose = Console.ReadLine();

}
while (choose == "yes");


/*Employee employee2;
Console.WriteLine("enter your name");
string name2 = Console.ReadLine();
Console.WriteLine("enter your EmployeeType : FullTime  or PartTime");
string EmployeeType2 = Console.ReadLine();
if (EmployeeType2 == "FullTime")

{
    Console.WriteLine("enter your Salary");
    decimal Salary = Convert.ToDecimal(Console.ReadLine());

    employee2 = new FullTimeEmployee(name2, Salary);
}
else if (EmployeeType2 == "PartTime")
{
    Console.WriteLine("enter your CountHour");
    int CountHoure = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("enter your HourlyRate");
    decimal HourlyRate = Convert.ToDecimal(Console.ReadLine());
    employee2 = new PartTimeEmployee(name2, CountHoure, HourlyRate);


}

else
{
    throw new Exception();
}
employee2.DisplayInfo();
IWorkable workable2 = (IWorkable)employee2;
workable2.Work();*/


