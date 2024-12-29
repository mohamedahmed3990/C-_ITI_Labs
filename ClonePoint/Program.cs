using Lab8;

namespace ClonePoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D(10, 20, 30);

            Point3D p2 = new Point3D(30,30,30);

            Point3D p3 = (Point3D) p2.Clone();

            Console.WriteLine(p3);
        }
    }
}
