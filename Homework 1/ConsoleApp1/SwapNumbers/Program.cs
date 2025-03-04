Console.WriteLine("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"a = {a}, b = {b}"); //before
int c;
c = a;
a = b;
b = c;

//(a, b) = (b, a); -> experimented with
Console.WriteLine($"a = {a}, b = {b}"); //after