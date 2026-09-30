CalculatorApp();

void CalculatorApp()
{
    int firstNumber = 0;
    int secondNumber = 0;
    int result = 0;
    int choice = 0;

    Console.WriteLine("Type in the first number followed by Enter key");
    firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Type in the second number followed by Enter key");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Choose an option from the list below:");
    Console.WriteLine("1- Add");
    Console.WriteLine("2- Subtract");
    Console.WriteLine("3- Multiply");
    Console.WriteLine("4- Divide");

    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {
        result = firstNumber + secondNumber;
        Console.WriteLine($"Adding {firstNumber} and {secondNumber} equals {result}");
    }
    else if (choice == 2)
    {
        result = firstNumber - secondNumber;
        Console.WriteLine($"Subtracting {secondNumber} from {firstNumber} equals {result}");
    }
    else if (choice == 3)
    {
        result = firstNumber * secondNumber;
        Console.WriteLine($"Multiplying {firstNumber} by {secondNumber} equals {result}");
    }
    else if (choice == 4)
    {
        result = firstNumber / secondNumber;
        Console.WriteLine($"Dividing {firstNumber} by {secondNumber} equals {result}");
    }
    else
    {
        Console.WriteLine("You did not select a valid number between 1 and 4");
    }
}