public class Program
{

    public static bool IsPerfectSquare(int x)
    {
        int s = (int)Math.Sqrt(x);
        return (s * s == x);
    }

    public static bool IsFibonacci(int n)
    {
        return IsPerfectSquare(5 * n * n + 4) || IsPerfectSquare(5 * n * n - 4);
    }

    public static void Main()
    {
        int n;

        Console.Write("Digite um número: ");
        n = int.Parse(Console.ReadLine()); 

        if (IsFibonacci(n))
        {
            Console.WriteLine("{0} pertence à sequência de Fibonacci", n);
        }
        else
        {
            Console.WriteLine("{0} não pertence à sequência de Fibonacci", n);
        }
    }
}
