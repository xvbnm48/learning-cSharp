using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1 
{
    public class Sololearn
    {
        public class Belajar
        {
            public static void Sololearn()
            {
                int a = 8;
                int b = ++a;
                if (a > 5)
                {
                    b -= 3;
                }
                else
                {
                    b = 9;
                }
                Console.WriteLine(b);
                // const double pi = 3.14;
                // double radius = Double.Parse(Console.ReadLine());
                // double area = pi * Math.Pow(radius, 2);
                // Console.WriteLine(area);
                // const double pi = 3.14;
                // double radius;
                // Console.WriteLine("masukkan jari-jari");
                // radius = Convert.ToDouble(Console.ReadLine());
                // double hasil = (int)(pi * 2 * radius);
                // Console.WriteLine("luas lingkaran adalah: " + hasil);
            }

            public static void SoloLearn2()
            {
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 1)
                {
                    Console.WriteLine("Easy");
                } else if (num == 2)
                {
                    Console.WriteLine("Medium");
                } else if (num == 3)
                {
                    Console.WriteLine("Hard");
                }
                else
                {
                    Console.WriteLine("Invalid option");
                }
            }
            public static void SoloLearn3()
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine(i*80);
                }
            }
        }
    }
    
}
