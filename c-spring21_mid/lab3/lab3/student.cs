using System;
namespace lab3
{
    public class student
    {
        public student()
        { private string name;
        private string id;
        private string department;
        private float cgpa;

        public Student() { }

        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public string Department { get => department; set => department = value; }
        public float Cgpa { get => cgpa; set => cgpa = value; }

        public void showinfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("Cgpa: " + cgpa);
        }

    } }

}
