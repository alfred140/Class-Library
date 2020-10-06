using ClassLibrary;
using System;
using System.Collections.Generic;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shapes = new List<string>();

            string triang = "";

            for (int i = 0; i < 20; i++)
            {
                shapes.Add(Shape.GenerateShape());                

            }
            foreach (string s in shapes)
            {
                Console.WriteLine(s);
            }
            

            Console.ReadKey();

        }
    }
}
