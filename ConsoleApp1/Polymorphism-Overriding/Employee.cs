using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Polymorphism_Overriding
{
    public class Employee
    {
        public Employee(int id, string name, int age)
        {
            Id = id;
            this.name = name;
            this.age = age;
        }

        public int Id { get; set; }
        public string name { get; set; }

        public int age { get; set; }

        public Employee()
        {
            
        }


        public void GetEmployeeType()
        {
            Console.WriteLine("I am Employee");
        }

        public virtual void GetEmoployeeData()
        {
            Console.WriteLine($"Employee : ID = {Id} ,Name = {name} , age = {age} ");
        
        }
    }


}
