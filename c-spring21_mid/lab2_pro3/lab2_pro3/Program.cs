using System;

namespace lab2_pro3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int phy = 70, chem = 80, bio = 75, math = 90, eng = 91;
                float percent;

                percent = (phy + chem + bio + math + eng) / 5.0f;

                Console.WriteLine("average = " + percent);


               
                if (percent >= 90)
                {
                    Console.WriteLine("Grade A+");
                }
                else if (percent >= 85 && percent <= 89)
                {
                    Console.WriteLine("Grade A");
                }
                else if (percent >= 80 && percent <= 84)
                {
                    Console.WriteLine("Grade B+");
                }
                else if (percent >= 75 && percent <= 79)
                {
                    Console.WriteLine("Grade B");
                }
                else if (percent >= 50 && percent <= 74)
                {
                    Console.WriteLine("Grade C+");
                }
                else
                {
                    Console.WriteLine("Grade F");
                }
            }
        }
    }
}
