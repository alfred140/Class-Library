using System;
using System.Numerics;

namespace ClassLibrary
{
    public class Triangle : Shape2D
    {

        readonly float P1X;
        readonly float P1Y;
        readonly float P2X;
        readonly float P2Y;
        readonly float P3X;
        readonly float P3Y;

        readonly float SideA;
        readonly float SideB;
        readonly float SideC;


        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            P1X = p1.X;
            P1Y = p1.Y;

            P2X = p2.X;
            P2Y = p2.Y;

            P3X = p3.X;
            P3Y = p3.Y;

            SideA = (float)Math.Sqrt(Math.Pow((P1X - P2X), 2) + Math.Pow((P1Y - P2Y), 2));
            SideB = (float)Math.Sqrt(Math.Pow((P3X - P2X), 2) + Math.Pow((P3Y - P2Y), 2));
            SideC = (float)Math.Sqrt(Math.Pow((P3X - P1X), 2) + Math.Pow((P3Y - P1Y), 2));

        }
        public override float Circumference => SideA + SideB + SideC;

        public override Vector3 Center
        {
            get
            {
                float midpointX = (P2X + P3X) / 2;
                float midpointY = (P2Y + P3Y) / 2;
                float centerX = ((2 * midpointX) + (1 * P1X)) / (2 + 1);
                float centerY = ((2 * midpointY) + (1 * P1Y)) / (2 + 1);

                return new Vector3(centerX, centerY, 0f);
            }
        }

        public override float Area
        {
            get
            {
                float half = Circumference / 2;

                return (float)Math.Sqrt(half * (half - SideA) * (half - SideB) * (half - SideC));
            }

        }

        public override string ToString()
        {

            return $"Triangle @ {(Math.Round(Center.X, 1), Math.Round(Center.Y, 1))}: p1{(P1X, P1Y)}, p2{(P2X, P2Y)}, p3{(P3X, P3Y)}";
        }
    }
}
