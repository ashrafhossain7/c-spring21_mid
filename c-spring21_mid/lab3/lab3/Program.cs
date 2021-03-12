using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Class Program");
            Student s = new Student();
            s.Name = "ashraf";
            s.Id = "18-38928-3";
            s.Department = "CSE";
            s.Cgpa = 3.50f;
            s.showinfo();

            Console.WriteLine("Triangle Class Program");

            Triangle t = new Triangle();
            t.X = 20;
            t.Y = 30;
            t.Z = 20;

            t.showinfo();
            t.TestTriangle();
            Console.WriteLine("Account Class Program");
            Account a = new Account();
            a.AccName = "Saif";
            a.Acid = "123456";
            a.Deposit = 80000;
            a.Withdraw = 2000;
            a.Balance = a.Deposit - a.Withdraw;
            a.showinfo();

            Console.WriteLine("Course Class Program");
            Course c = new Course();
            c.CourseName = "PLL2";
            c.CourseCode = "123456";
            c.CourseCredit = 3;

            c.ShowCourseInfo();


        }
    }
}
