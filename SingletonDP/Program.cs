namespace SingletonDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NIC nIC = new NIC();

            NIC nIC = NIC.Obj;

            Console.WriteLine(nIC);
            Console.WriteLine(nIC.GetHashCode());

            NIC nIC2 = NIC.Obj;

            Console.WriteLine(nIC2);
            Console.WriteLine(nIC2.GetHashCode());


        }
    }
}
