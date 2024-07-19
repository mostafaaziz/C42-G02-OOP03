using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Polymorphism_Overriding
{
    internal class TypeA
    {
        public int A { get; set; }

        public TypeA(int a)
        {
            A = a;
        }

        public void MyFun01()
        {
            Console.WriteLine("I am Base [Parent]");

        }

        public virtual void MyFun02()
        {
            Console.WriteLine($" TypeA : A = {A}");
        }
    }

   
}
