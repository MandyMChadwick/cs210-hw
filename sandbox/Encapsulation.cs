//https://www.c-sharpcorner.com/blogs/what-is-an-encapsulation this code was found at this website

using System;
namespace OPPs
{

    Class Encapsulation
    {


      private string Name;
    public string EmployeeName
    {
        get { return Name; }
        set Name = value;


        }


              static void Main(string[] args)
    {
        string Name2 = string.Empty;
        Encapsulation e = new Encapsulation();
        Name22 = e.EmployeeName;
        Console.WriteLine("Employee Name" + Name2);
        Console.ReadLine();
    }
}   
}   