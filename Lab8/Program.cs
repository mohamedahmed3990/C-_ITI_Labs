namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1
            //Point3D point = new Point3D(10, 10, 10);
            //Console.WriteLine(point.ToString());

            //string str = (string) point;

            //Console.WriteLine(str); 
            #endregion


            #region Part2
            //bool checkP1;
            //int p1;

            //do 
            //{
            //    Console.Write("Please enter p1: ");
            //    checkP1 = int.TryParse(Console.ReadLine(), out p1);               
            //}
            //while (!checkP1);

            //bool checkP2;
            //int p2;

            //do
            //{
            //    Console.Write("Please enter p2: ");
            //    checkP2 = int.TryParse(Console.ReadLine(), out p2);
            //}
            //while (!checkP2);

            //bool checkP3;
            //int p3;

            //do
            //{
            //    Console.Write("Please enter p3: ");
            //    checkP3 = int.TryParse(Console.ReadLine(), out p3);
            //}
            //while (!checkP3);

            //Point3D point3D = new Point3D
            //{
            //    P1 = p1,
            //    P2 = p2,
            //    P3 = p3
            //};

            //Console.WriteLine(point3D.ToString()); 
            #endregion


            #region Part3 Array
            //Point3D[] point3Ds = new Point3D[3];

            //for (int i = 0; i < point3Ds.Length; i++)
            //{
            //    bool check;
            //    int point1;

            //    do
            //    {
            //        Console.Write($"Please enter p1: ");
            //        check = int.TryParse(Console.ReadLine(), out point1);
            //    }
            //    while (!check);
            //    check = false;

            //    int point2;

            //    do
            //    {
            //        Console.Write($"Please enter p2: ");
            //        check = int.TryParse(Console.ReadLine(), out point2);
            //    }
            //    while (!check);
            //    check = false;

            //    int point3;

            //    do
            //    {
            //        Console.Write($"Please enter p3: ");
            //        check = int.TryParse(Console.ReadLine(), out point3);
            //    }
            //    while (!check);
            //    check = false;

            //    point3Ds[i] = new Point3D(point1, point2, point3);
            //}

            //foreach (var item in point3Ds)
            //{
            //    Console.WriteLine(item.ToString());
            //} 
            #endregion

            #region Overide Equals
            //Point3D p1 = new Point3D(10,20,30);
            //Point3D p2 = new Point3D(1,2,3);
            //Point3D p3 = new Point3D(10,20,30);


            //Console.WriteLine(p1.Equals(p2));

            ////p1 = p2;

            //Console.WriteLine(p1.Equals(p2));
            //Console.WriteLine(p1.Equals(p3)); 
            #endregion
        }
    }
}
