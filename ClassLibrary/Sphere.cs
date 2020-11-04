using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace ClassLibrary
{
   public class Sphere : Shape3D
    {
        readonly float CenterX;
        readonly float CenterY;
        readonly float CenterZ;

        readonly float Radius;

        public Sphere(Vector3 center, float radius)
        {
            CenterX = center.X;
            CenterY = center.Y;
            CenterZ = center.Z;

            Radius = radius;
        }
        public override float Volume => (float)((4.0/3.0) * Math.PI * Math.Pow(Radius, 3));

        public override Vector3 Center => new Vector3(CenterX, CenterY, CenterZ);

        public override float Area => (float)(4 * Math.PI * Math.Pow(Radius, 2));

        public override string ToString()
        {
            return $"Sphere @ {(CenterX, CenterY, CenterZ)}: R = {Radius}";
        }
    }
}
