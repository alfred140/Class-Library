using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Numerics;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            for (int i = 0; i < 20; i++)
            {
                shapes.Add(Shape.GenerateShape(new Vector3(1, 3, 2)));

                Console.WriteLine(shapes[i] + "\n");
            }

            float AllPerimeters = 0;
            float AllArea = 0;
            float maxVol = 0;
            string volShape = "";
            foreach (Shape s in shapes)
            {
                float addArea = s.Area;
                AllArea += addArea;

                if (s is Triangle t)
                {
                    float addTri = t.Circumference;
                    AllPerimeters += addTri;
                }

                if (s is Shape3D s3D)
                {
                    float Max3D = s3D.Volume;                    

                    Math.Max(Max3D, maxVol);
                    if (Max3D > maxVol)
                    {
                        maxVol = Max3D;
                        volShape = s3D.ToString();
                    }
                }
            }

            Console.WriteLine($"\n Total circumference of triangles: {Math.Round(AllPerimeters, 2)}");

            Console.WriteLine($"\n Averege area of all shapes: {Math.Round((AllArea / shapes.Count), 2)}");

            Console.WriteLine($"\n Max volume: {maxVol}, from shape: {volShape.ToString()}");

            Console.ReadKey();

        }
    }
}
