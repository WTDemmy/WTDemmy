namespace Week4;

class Program
{
    static void Main(string[] args)
    {
        // Q1 METHOD
        Console.WriteLine("Enter first number: ");
        int a = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Enter second number: ");
        int b = Convert.ToInt16(Console.ReadLine());

        int largest = Q1(a, b);
        Console.WriteLine($"The largest number is {largest}");
        
        // Q2 METHOD
        Console.WriteLine("Assign an integer to N:");
        int N = Convert.ToInt16(Console.ReadLine());
        
        Console.WriteLine("Enter the shape (left or right):");
        string input_shape = Console.ReadLine();
        Q2(N,input_shape);

    }

    static int Q1 ( int a, int b){
        return(a>b) ? a:b;
    }

    static void Q2(int N, string input_shape)
        {
            Console.WriteLine($"Assign an Integer to N: {N}, Shape is: {input_shape}");

            if (input_shape == "left")
            {
                // Print left-side triangle
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
            else if (input_shape == "right")
            {
                // Print right-side triangle
                for (int i = 1; i <= N; i++)
                {
                    for (int j = N; j > i; j--)
                    {
                        Console.Write("  "); 
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid shape.");
            }
        }
}