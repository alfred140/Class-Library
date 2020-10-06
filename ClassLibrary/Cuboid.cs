using System.Numerics;
using System.Runtime.CompilerServices;

namespace ClassLibrary
{
    class Cuboid : Shape3D

    {
        readonly float centerX;
        readonly float centerY;
        readonly float centerZ;

        readonly float SizeX;
        readonly float SizeY;
        readonly float SizeZ;
        
        public Cuboid(Vector3 center, Vector3 size)
        {
            centerX = center.X;
            centerY = center.Y;
            centerZ = center.Z;

            SizeX = size.X;
            SizeY = size.Y;
            SizeZ = size.Z;

        }
        public Cuboid(Vector3 center, float width)
        {
            centerX = center.X;
            centerY = center.Y;
            centerZ = center.Z;

            SizeX = width;
            SizeY = width;
            SizeZ = width;

        }
        public override float Volume => SizeX * SizeY * SizeZ;

        public override Vector3 Center => new Vector3((centerX + SizeX) / 2, (centerY + SizeY) / 2, (centerZ + SizeZ) / 2);

        public override float Area => 2 * ((SizeX * SizeY) + (SizeY*SizeZ) + (SizeZ*SizeX));


        public bool IsCube
        {
            get 
            {
                if (SizeX == SizeY & SizeY == SizeZ)
                    return true;
                else
                    return false;
            }            
        }
        public override string ToString()
        {
            

            if (IsCube)
            {
                
                return $"Cube @ {(centerX, centerY, centerZ)}, W = {SizeX}, H = {SizeY}, L = {SizeZ}";
            }
            else
            {
               
                return $"Cuboid @ {(centerX, centerY, centerZ)}, W = {SizeX}, H = {SizeY}, L = {SizeZ}";
            }
        }
    }
}
