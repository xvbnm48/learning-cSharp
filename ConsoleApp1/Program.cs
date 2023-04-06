// See https://aka.ms/new-console-template for more information
using System;
using ConsoleApp1;

namespace HelloWorld
{
    class Hello
    {
        static void Main(string[] args)
        {
            // Sololearn.Belajar.Sololearn();
            Sololearn.Belajar.SoloLearn3();
            string idol = "Aruno nakanishi";
            Console.WriteLine("hello " + idol);
            // const int myNum = 15;
            // // myNum = 20;
            // Console.WriteLine(myNum);
            int x = 5, y = 8, z = 10;
            x += 3;
            Console.WriteLine(x);
            Console.WriteLine(x + y + z);
                double num = 10.9;
                int myInt = (int)num;
                Console.WriteLine(myInt);
                Console.WriteLine(Convert.ToString(x));
            // Console.WriteLine("input your name oshi");
            // string nameOshi = Console.ReadLine();
            //
            // Console.WriteLine("oshi lu " + nameOshi + " dan panjang nama oshi lu itu " + nameOshi.Length);
            string firtsName = "fariz";
            string lastName = "prananda";
            string myName = $"my full name is: {firtsName} {lastName}";
            Console.WriteLine(myName);

            if (x <=  y)
            {
                Console.WriteLine("anjay");
            }
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(myName);
            }
        }
    }
}