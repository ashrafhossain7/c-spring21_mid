using System;
namespace lab3
{
    public class triangle
    {
        public triangle()
        {
            private int x;
        private int y;
        private int z;

        public Triangle() { }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Z { get => z; set => z = value; }



        public void showinfo()
        {
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);
            Console.WriteLine("Z = " + z);


        }

        public void TestTriangle()
        {
            if (x == y && y == z && z == x)
            {
                Console.WriteLine("Equilateral triangle");
            }
            else if (x == y || y == z || z == x)
            {
                Console.WriteLine("Isosceles triangle");

            }
            else
            {
                Console.WriteLine("Scalene triangle");
            }
        }
    }
}
}
