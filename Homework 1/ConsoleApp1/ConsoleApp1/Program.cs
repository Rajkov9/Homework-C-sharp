Console.WriteLine("Enter the first number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

char calculation = Convert.ToChar(Console.ReadLine());
switch (calculation)
{
    case '+':
        Console.WriteLine(firstNumber + secondNumber);
        break;
    case '-':

        Console.WriteLine(firstNumber - secondNumber);
        break;
    case '*':
        Console.WriteLine(firstNumber * secondNumber);
        break;
    case '/':
        Console.WriteLine(firstNumber / secondNumber);
        break;
    default:
        Console.WriteLine("You've enterede a wrong operator");
        break;
}