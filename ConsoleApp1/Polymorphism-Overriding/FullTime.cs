using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Polymorphism_Overriding
{
    public class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }

        public FullTimeEmployee(int id , string name , int age , decimal salary) : base(id , name , age)
        {
            Salary = salary;
            
        }

        public new void GetEmployeeType()
        {
            Console.WriteLine("I am Full Time Employee");
        }

        public override void GetEmoployeeData()
        {
            Console.WriteLine($"FullTimeEmployee : ID = {Id} ,Name = {name} , age = {age} , Salary = {Salary} ");

        }
    }
}
