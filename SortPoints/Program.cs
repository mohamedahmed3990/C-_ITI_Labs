using Lab8;

namespace SortPoints
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D[] points =
            {
                new Point3D(10,10,50),
                new Point3D(10,10,40),
                new Point3D(50,60,30),
                new Point3D(15,20,30),
            };


            Array.Sort(points);

            foreach (Point3D point in points)
            {
                Console.WriteLine(point);
            }

            
        }
    }
}
