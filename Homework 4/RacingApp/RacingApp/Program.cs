using Domain.Models;
List<Car> cars = new List<Car>
        {
            new Car("Hyundai", 140),
            new Car("Mazda", 160),
            new Car("Ferrari", 220),
            new Car("Porsche", 200)
        };

List<Driver> drivers = new List<Driver>
        {
            new Driver("Bob", 3),
            new Driver("Greg", 4),
            new Driver("Jill", 2),
            new Driver("Anne", 5)
        };

bool raceAgain = true;
while (raceAgain)
{
    Console.Clear();
    Console.WriteLine("Welcome to the Car Race Simulator!\n");

    Car car1 = ChooseCar(cars, "first");
    Driver driver1 = ChooseDriver(drivers, "first");
    car1.Driver = driver1;

    Car car2 = ChooseCar(cars.Where(c => c != car1).ToList(), "second");
    Driver driver2 = ChooseDriver(drivers.Where(d => d != driver1).ToList(), "second");
    car2.Driver = driver2;

    RaceCars(car1, car2);

    Console.Write("Do you want to race again? (Y/N): ");
    string again = Console.ReadLine().Trim().ToLower();
    raceAgain = again == "y";
}

Console.WriteLine("Thanks for racing!");

static Car ChooseCar(List<Car> availableCars, string carLabel)
{
    Console.WriteLine($"\nChoose a {carLabel} car:");
    for (int i = 0; i < availableCars.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {availableCars[i].Model}");
    }

    while (true)
    {
        Console.Write("Enter option number: ");
        if (int.TryParse(Console.ReadLine(), out int choice) &&
            choice >= 1 && choice <= availableCars.Count)
        {
            return availableCars[choice - 1];
        }
        Console.WriteLine("Invalid selection. Try again.");
    }
}

static Driver ChooseDriver(List<Driver> availableDrivers, string driverLabel)
{
    Console.WriteLine($"\nChoose a {driverLabel} driver:");
    for (int i = 0; i < availableDrivers.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {availableDrivers[i].Name}");
    }

    while (true)
    {
        Console.Write("Enter option number: ");
        if (int.TryParse(Console.ReadLine(), out int choice) &&
            choice >= 1 && choice <= availableDrivers.Count)
        {
            return availableDrivers[choice - 1];
        }
        Console.WriteLine("Invalid selection. Try again.");
    }
}
static void RaceCars(Car car1, Car car2)
{
    double speed1 = car1.CalculateSpeed();
    double speed2 = car2.CalculateSpeed();

    Console.WriteLine(" Race Results");

    if (speed1 > speed2)
    {
        Console.WriteLine("Car 1 wins!");

        if (car1.Driver != null)
            Console.WriteLine($"{car1.Driver.Name} drove the {car1.Model} at speed {speed1:F2}.");
        else
            Console.WriteLine($"The {car1.Model} was driven by an unknown driver at speed {speed1:F2}.");
    }
    else if (speed2 > speed1)
    {
        Console.WriteLine("Car 2 wins!");

        if (car2.Driver != null)
            Console.WriteLine($"{car2.Driver.Name} drove the {car2.Model} at speed {speed2:F2}.");
        else
            Console.WriteLine($"The {car2.Model} was driven by an unknown driver at speed {speed2:F2}.");
    }
    else
    {
        Console.WriteLine("It's a tie!");

        string driver1 = car1.Driver != null ? car1.Driver.Name : "Unknown";
        string driver2 = car2.Driver != null ? car2.Driver.Name : "Unknown";

        Console.WriteLine($"{driver1} in {car1.Model} and {driver2} in {car2.Model} both went {speed1:F2}.");
    }
}