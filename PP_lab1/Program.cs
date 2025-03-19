namespace PP_lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of items:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the seed:");
            int seed = int.Parse(Console.ReadLine());

            Problem problem = new Problem(n, seed);
            Console.WriteLine("Generated Items:");
            Console.WriteLine(problem);

            Console.WriteLine("Enter the capacity:");
            int capacity = int.Parse(Console.ReadLine());

            Result result = problem.Solve(capacity);
            Console.WriteLine("\nSolution:");
            Console.WriteLine(result);
        }
    }
}
