static void SumOfEven()
{
    int[] array = new int [6];
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        while (true)
        {
            Console.WriteLine("Please enter a number so that it may be added to the array.");
            if(int.TryParse(Console.ReadLine(), out array[i]))
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input.Please enetr a valid number");
            }
        }
        sum += array[i];
    }
    Console.WriteLine("The total sum is: " + sum); //the result in the test output is wrong
}

SumOfEven();