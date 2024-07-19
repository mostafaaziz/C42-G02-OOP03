using ConsoleApp1.Polymorphism_Overriding;
using System.Diagnostics;

namespace ConsoleApp1
{
    internal class Program
    {
        //Employee employee
        //Can Ref => Obj Employee
        //Can Ref => Obj From Clas Inhert From Employee [Fulltime , parttime]
        public static void ProcessEmployee(Employee employee)
        {
            if (employee != null) 
            {
                employee.GetEmployeeType();
                employee.GetEmoployeeData();
            }
        }

        //public static void ProcessEmployee(PartTimeEmployee employee)
        //{
        //    if (employee != null)
        //    {
        //        employee.GetEmployeeType();
        //        employee.GetEmoployeeData();
        //    }
        //}
        //Not Overloding

        static void Main(string[] args)
        {
            #region Overriding

            //TypeA typeA = new TypeA(1);
            //typeA.A = 10;
            //typeA.MyFun01();
            //typeA.MyFun02();

            //Console.WriteLine("/////////////////////////");

            //TypeB typeB = new TypeB(1, 2);
            //typeB.A = 20;
            //typeB.B = 30;
            //typeB.MyFun01();
            //typeB.MyFun02();

            #endregion

            #region Binding

            //TypeA refBase = new TypeB(1 , 2);
            //refBase.A = 20;
            //refBase.MyFun01();
            //refBase.MyFun02();

            #endregion

            #region Not Binding

            ////Ref From Child  => Obj From Parent
            //TypeB ChildRef = new TypeA();  // Invalid
            //TypeB ChildRef = (TypeB) new TypeA(1); // Not Binding
            //// Explicit Casting
            //// UnSave Casting

            //TypeA typeA = new TypeA(1);
            //TypeB typeB = (TypeB)typeA; //Ecplicit casting
            //                            // (TypeB) => Casting Operator - Function
            //Console.WriteLine(TypeB.A);
            //Console.WriteLine(TypeB.B);

            //TypeA typeA = new TypeB(1 , 2);
            //TypeB typeB = (TypeB)typeA; //Ecplicit casting
            //                            // (TypeB) => Casting Operator - Function
            //Console.WriteLine(TypeB.A);
            //Console.WriteLine(TypeB.B);


            #endregion

            #region FullTime

            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee(10 , "Mostafa" , 24 , 4500);
            //ProcessEmployee(fullTimeEmployee);

            #endregion

            #region PartTime

            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee()
            //{
            //    Id = 20,
            //    name = "Mostafa",
            //    age = 24,
            //    HourRate = 2.4M,
            //    CountOfHours = 20
            //};
            //ProcessEmployee(partTimeEmployee); //Invalid



            #endregion

            #region Binding Ex2

            //TypeA typeA = new TypeC(1,2,3);
            //typeA.A = 10;
            //typeA.MyFun01();
            //typeA.MyFun02();

            //TypeB typeB = new TypeC(1,2,3);
            //typeB.A = 10;
            //typeB.B = 20;
            //typeB.MyFun01();
            //typeB.MyFun02();

            #endregion


        }

    }
}
