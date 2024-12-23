namespace Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str = "this is a test";

            Console.Write("please enter some words: ");
            string str = Console.ReadLine();

            string result = string.Join(" ", str.Split(" ").Reverse());

            Console.WriteLine(result);
        }
    }
}
