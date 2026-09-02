const double nairaToDollarRate = 0.0024;
const double kilometerstomils = 0.621371;
const double kilogramtopounds = 2.20462;

bool running = true;
while (running)
{
    Console.WriteLine("Select an option:");
    Console.WriteLine("1. Convert Naira to Dollar");
    Console.WriteLine("2. Convert Kilometers to Miles");
    Console.WriteLine("3. Convert Kilograms to Pounds");
    Console.WriteLine("4. Exit");
    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.WriteLine("Enter amount in Naira: ");
            double nairaAmount = double.Parse(Console.ReadLine());
            double dollarAmount = nairaAmount * nairaToDollarRate;
            Console.WriteLine($"{nairaAmount} Naira is equal to {dollarAmount} Dollars.");
            break;
        case "2":
            Console.WriteLine("Enter distance in Kilometers: ");
            double kilometers = double.Parse(Console.ReadLine());
            double miles = kilometers * kilometerstomils;
            Console.WriteLine($"{kilometers} Kilometers is equal to {miles} Miles.");
            break;
        case "3":
            Console.WriteLine("Enter weight in Kilograms: ");
            double kilograms = double.Parse(Console.ReadLine());
            double pounds = kilograms * kilogramtopounds;
            Console.WriteLine($"{kilograms} Kilograms is equal to {pounds} Pounds.");
            break;
        case "4":
            Console.WriteLine("Thank you for using the converter. Goodbye!");
            running = false;
            break;
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
    Console.WriteLine();
}

static double readdouble()
{
    double value;
    while (!double.TryParse(Console.ReadLine(), out value))
    {
        Console.WriteLine("invalid input, enter an integer number");
    }
    return value;
}