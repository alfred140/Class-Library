using System;
using System.Numerics;

namespace ClassLibrary
{
    public class Circle : Shape2D
    {

        private float Radius;
        private float CenterX;
        private float CenterY;
        public Circle(Vector2 center, float radius)
        {

            Radius = radius;
            CenterX = center.X;
            CenterY = center.Y;


        }
        public override float Circumference => (float)(Radius * 2.0f * Math.PI);

        public override float Area => (float)(Math.Pow(Radius, 2.0f) * Math.PI);

        public override Vector3 Center => new Vector3(CenterX, CenterY, 0f);

        public override string ToString()
        {

            return $"Circle @ {(CenterX, CenterY)}: R: {Radius}";
        }


    }
}
