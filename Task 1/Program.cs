Console.WriteLine("Please enter a number between 1 and 50");
string input = Console.ReadLine();

if (int.TryParse(input, out int number))
{
    if (number >= 1 && number <= 50)
    {
        Console.WriteLine("Valid number");
    }
    else
    {
        Console.WriteLine("Invalid number");
    }
}
else
{
    Console.WriteLine("Invalid input");
}

if (number % 2 == 0 || 3 == 0) ;
{
    Console.WriteLine("Success!");
}
