using System.Numerics;

namespace ClassLibrary
{
   public class Rectangle : Shape2D
    {
        readonly float centerX;
        readonly float centerY;        

        readonly float SizeX;
        readonly float SizeY;       

        public Rectangle(Vector2 center, Vector2 size)
        {
            centerX = center.X;
            centerY = center.Y;

            SizeX = size.X;
            SizeY = size.Y;

        }
        public Rectangle(Vector2 center, float width)
        {
            centerX = center.X;
            centerY = center.Y;
            
            SizeY = width;
            SizeX = width;
        }

        public override float Circumference => SizeX * 2 + SizeY * 2;
        public override float Area => SizeX * SizeY;
        public override Vector3 Center => new Vector3(centerX + SizeX / 2, centerY + SizeY / 2, 0);


        public bool IsSquared
        {
            get
            {
                if (SizeX == SizeY)
                    return true;
                else
                    return false;
            }
            
            
        }

        public override string ToString()
        {

            if (IsSquared)
            {
                return $"Square @ {(centerX, centerY)}: W = {SizeX}, H = {SizeY}";
            }

            else
            {
                return $"Rectangle @ {(centerX, centerY)}: W = {SizeX}, H = {SizeY}";
            }
        }

    }
}
