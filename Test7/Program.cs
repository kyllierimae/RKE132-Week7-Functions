

Console.WriteLine("Enter 1, if you want to conver Fahrenheit to Celsius or 2 if you want to convert Celsius to Fahrenheit.");
int userChoice = int.Parse(Console.ReadLine());
if (userChoice == 1 || userChoice == 2)
{
    Console.WriteLine("What temperature do you want to convert?");
    double userInput = double.Parse(Console.ReadLine());
    double result = ConvertToCelsius(userInput);
    Console.WriteLine($"{userInput} Fahrenheit is {result} Celsius.");
}
else
{
    Console.WriteLine("Wrong input!");
}


static double ConvertToCelsius(double userInput)
{
    return (userInput - 32) * 5 / 9;
}

static double ConvertToFahrenheit(double userInput)
{
    return (userInput * 9) / 5 + 32;
}