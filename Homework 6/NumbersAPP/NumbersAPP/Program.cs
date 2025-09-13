Queue<double> numbers = new Queue<double>();
string choice;

do
{
    Console.Write("Enter a number: ");
    double num = Convert.ToDouble(Console.ReadLine());
    numbers.Enqueue(num);

    Console.Write("Do you want to enter another number? (Y/N): ");
    choice = Console.ReadLine().ToUpper();
}
while (choice == "Y");

Console.WriteLine("Numbers in the order you entered:");
while (numbers.Count > 0)
{
    Console.WriteLine(numbers.Dequeue());
}