using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Polymorphism_Overriding
{
    internal class TypeC : TypeB
    {
        public int C { get; set; }

        public TypeC(int a, int b, int c) : base( a , b)
        {
            C = C;
        }
        public new void MyFun01()
        {
            Console.WriteLine("I am GrandChild ");

        }

        public override void MyFun02()
        {
            Console.WriteLine($" TypeC : A = {A} , B = {B} , C = {C}");
        }
    }
}
