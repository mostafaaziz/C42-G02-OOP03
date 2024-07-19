using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1.Polymorphism_Overriding
{
    public class PartTimeEmployee : Employee
    {
        public int CountOfHours { get; set; }
        public decimal HourRate { get; set; }

        public new void GetEmployeeType()
        {
            Console.WriteLine("I am Full Time Employee");
        }

        public override void GetEmoployeeData()
        {
            Console.WriteLine($"Part TimeEmployee : ID = {Id} ,Name = {name} , age = {age} , CountOfHour = {CountOfHours} , OurRate = {HourRate } ");

        }
    }
}
