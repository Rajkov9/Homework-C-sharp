string[] studentsG1 = new string[] {"Zdravko", "Petko", "Stanko", "Branko", "Trajko"} ;
string[] studentsG2 = new string[] { "Sinisha", "Jovanche", "Aleksandra", "Ivan", "Ljubisha" };
int option = GetStudentGroup();

if (option == 1)
{
    foreach (var s in studentsG1)
    {
        Console.WriteLine(s);
    }
}
else
{
    foreach (var s2 in studentsG2)
    {
        Console.WriteLine(s2);
    }
}
    static int GetStudentGroup()
    {
        while (true)
        {
            Console.WriteLine("Please select option 1 or option 2 to select a student group");
            if (int.TryParse(Console.ReadLine(), out int option) && (option == 1 || option == 2))
            {
                return option;
            }
            else
            {
                Console.WriteLine("Invalid option.Please try again.");
            }
        }
    }