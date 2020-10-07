using System;
using System.Numerics;

namespace ClassLibrary
{
    public abstract class Shape
    {

        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

        
        public static Shape GenerateShape()
        {

            Random r = new Random();
            int random = r.Next(0, 7);


            switch (random)
            {
                case (0):

                    return new Circle(center: new Vector2(r.Next(0, 6), r.Next(0, 6)), radius: r.Next(1, 7)) ;

                case (1):

                    return new Rectangle(center: new Vector2(r.Next(0, 6), r.Next(0, 6)), size: new Vector2(r.Next(1, 7), r.Next(1, 7)));

                case (2):

                    return new Rectangle(center: new Vector2(r.Next(0, 6), r.Next(0, 6)), width: r.Next(1, 7));

                case (3):
                                                            
                    
                    return new Triangle(p1: new Vector2(r.Next(0, 6), r.Next(0, 6)), p2: new Vector2(r.Next(0, 6), r.Next(0, 6)), p3: new Vector2(r.Next(0, 6), r.Next(0, 6)));

                case (4):

                    return new Cuboid(center: new Vector3(r.Next(0, 6), r.Next(0, 6), r.Next(0, 6)), size: new Vector3(r.Next(1, 7), r.Next(1, 7), r.Next(1, 7)));

                case (5):

                    return new Cuboid(center: new Vector3(r.Next(0, 6), r.Next(0, 6), r.Next(0, 6)), width: r.Next(1, 7));

                default:

                    return new Sphere(center: new Vector3(r.Next(0, 6), r.Next(0, 6), r.Next(0, 11)), radius: r.Next(1, 7));

            
            }

        }
        public static Shape GenerateShape(Vector3 vector)
        {

            Random r = new Random();
            float random = r.Next(0, 7);

            switch (random)
            {
                case (0):

                    return new Circle(center: new Vector2(vector.X, vector.Y), radius: r.Next(1, 7));

                case (1):

                    return new Rectangle(center: new Vector2(vector.X, vector.Y), size: new Vector2(r.Next(1, 7), r.Next(1, 7)));

                case (2):

                    return new Rectangle(center: new Vector2(vector.X, vector.Y), width: r.Next(1, 7));

                case (3):
                    float p2x = r.Next(0, 6);
                    float p3x = r.Next(0, 6);
                    float p2y = r.Next(0, 6);
                    float p3y = r.Next(0, 6);
                    float p1x = (p2x + p3x);
                    float p1y = (p2y + p3y);


                    return new Triangle(p1: new Vector2(vector.X * 3 - p1x, vector.Y * 3 - p1y), p2: new Vector2(p2x, p2y), p3: new Vector2(p3x, p3y));

                case (4):

                    return new Cuboid(center: new Vector3(vector.X, vector.Y, vector.Z), size: new Vector3(r.Next(1, 7), r.Next(1, 7), r.Next(1, 7)));

                case (5):

                    return new Cuboid(center: new Vector3(vector.X, vector.Y, vector.Z), width: r.Next(1, 7));

                default:

                    return new Sphere(center: new Vector3(vector.X, vector.Y, vector.Z), radius: r.Next(1, 7));
            }
        }
    }
}
