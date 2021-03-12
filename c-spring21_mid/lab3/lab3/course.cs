using System;
namespace lab3
{
    public class course
    {
        public course()
        {        private string courseCode;
        private int courseCredit;



        public Course() { }

        public string CourseName { get; set; }
        public string CourseCode { get => courseCode; set => courseCode = value; }
        public int CourseCredit { get => courseCredit; set => courseCredit = value; }

        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name: " + CourseName);
            Console.WriteLine("Course Code: " + courseCode);
            Console.WriteLine("Course Credit: " + courseCredit);
        }
    } }

    }

