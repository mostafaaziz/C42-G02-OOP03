﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Polymorphism_Overriding
{
    internal class TypeD : TypeC
    {
        public int D { get; set; }
        public TypeD(int a , int b , int c , int d) : base(a , b , c)
        {
            D = d;
            
        }

        public new void MyFun01()
        {
            Console.WriteLine("I am GrandChild ");

        }
        public new virtual void MyFun02()
        {
            Console.WriteLine($" TypeD : A = {A} , B = {B} , C = {C} , D = {D}");
        }
    }
}
