while (true)
{
    Console.WriteLine("What is your name?");

    string? name = Console.ReadLine();

    Console.WriteLine($"Hello, {name}! How old are you?");

    if (!int.TryParse(Console.ReadLine(), out int age))
    {
        Console.WriteLine("Error!");
    }

    Console.WriteLine($"Great! You have {age} y.o. Do you want to verify your age?");

    Console.WriteLine($"Do you want to connect your location?");

    int timeout = 60;
}
