static DateTime EnterDate()
{
    DateTime birthDate;
    while (true)
    {
        Console.WriteLine("Please enter your full birthdate");
        if (DateTime.TryParse(Console.ReadLine(), out birthDate))
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please try again.");
        }
    }
    return birthDate;

}
static int CalculateAge(DateTime birthDate)
{
    DateTime today = DateTime.Today;
    int age = today.Year - birthDate.Year;
    if (birthDate > today.AddYears(-age))
    {
        age--;
    }
    return age;
}
DateTime birthDate = EnterDate();
Console.WriteLine(CalculateAge(birthDate));