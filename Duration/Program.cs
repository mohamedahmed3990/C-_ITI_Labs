namespace Duration
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Duration d1 = new Duration(600);

            Duration d2 = new Duration(3600);

            Duration d3 = new Duration();


            Console.WriteLine(d1);
            Console.WriteLine(d1.Equals(d2));

            d3 = d1 + d2; 
            d3 = d1 + 7800;
            d3 = 666 + d3;

            Console.WriteLine(d3);

            Console.WriteLine("**************");

            Console.WriteLine(++d1);

            Console.WriteLine(d1 > d2);

            DateTime date = (DateTime)d1;
            Console.WriteLine(date.ToString("HH:mm:ss"));

        }
    }
}
