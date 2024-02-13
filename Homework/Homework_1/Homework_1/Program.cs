namespace Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, j, i, k;
            n = 5;

            for (k = 1; k <= n; k++)
            {
                for (j = 1; j <= n - k; j++)
                {
                    Console.Write(" ");
                }
                for (i = 1; i <= 2 * k - 1; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
