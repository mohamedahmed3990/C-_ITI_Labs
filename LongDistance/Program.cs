namespace LongDistance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            0  1  2  3  4  5  6  7  8  9  10 11
            int[] arr = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };


            int longStep = 0;
            int steps = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        if (steps > longStep)
                            longStep = steps;
                    }
                    steps++;

                }
                steps = 0;
            }

            Console.WriteLine(longStep);
        }
    }
}
