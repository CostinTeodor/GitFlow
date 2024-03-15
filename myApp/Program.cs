// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();

        if (name == "admin") // Intentional bug: crashing for a specific input
        {
            // Intentional bug: divide by zero error
            int zero = 0;
            int result = 10 / zero;
        }
Console.WriteLine("Hello, Worl!");
