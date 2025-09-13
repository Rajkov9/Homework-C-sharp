using ATM;

Customers[] customers = new Customers[15];

customers[0] = new Customers("Aleksandar", "Trajkovski", 1234123412341234, "1234", 5000);
customers[1] = new Customers("Marija", "Petrovska", 9876987698769876, "4321", 3000);
customers[2] = new Customers("Goran", "Stojanovski", 5556555655565556, "5678", 1500);

while (true)
{
    Console.WriteLine("Welcome to the ATM!");
    Console.WriteLine("1. Login");
    Console.WriteLine("2. Register New Card");
    Console.Write("Choose an option: ");
    string choice = Console.ReadLine();
    if (choice == "1")
    {
        Customers customerAuthentication = Authentication(customers);
        if (customerAuthentication != null)
        {
            Console.WriteLine($" Welcome {customerAuthentication.FirstName} {customerAuthentication.LastName}!");
            UI(customerAuthentication);
        }
    }
    else if (choice == "2")
    {
        RegisterCustomer(customers);
    }
    else
    {
        Console.WriteLine("Invalid option.");
    }
}
static void UI(Customers customers)
{
    while (true) {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Balance Checking");
        Console.WriteLine("2. Cash Withdrawal");
        Console.WriteLine("3. Cash Deposit");
        Console.WriteLine("4. Exit");
        string option = Console.ReadLine();
        switch (option)
        {
            case "1":
                Console.WriteLine($"Your current balance is {customers.GetBalance()}");
                customers.GetBalance();
                break;
            case "2":
                Console.Write("Enter amount to withdraw: ");
                if (double.TryParse(Console.ReadLine(), out double funds))
                {
                    customers.CashWithdrawal(funds);
                }
                else
                {
                    Console.WriteLine("Invalid amount.");
                }
                break;
            case "3":
                Console.Write("Enter amount to deposit: ");
                if (double.TryParse(Console.ReadLine(), out double deposit))
                {
                    customers.CashDeposit(deposit);
                }
                else
                {
                    Console.WriteLine("Invalid amount.");
                }
                break;
            case "4":
                Console.WriteLine("Have a nice day");
                return;
            default:
                Console.WriteLine("Invalid option.");
                break;

        }
        Console.Write("Do you want to perform another action (Y/N)? ");
        string continueOption = Console.ReadLine();
        if (continueOption.ToLower() != "Y")
        {
            Console.WriteLine("Goodbye and good luck!");
            break;
        }
    }
}
static Customers Authentication(Customers [] customers)
{
    Console.WriteLine("Please enter your card number!");
    string cardNumIpt =Console.ReadLine();
    if (long.TryParse(cardNumIpt, out long cardNum))
    {
        Customers currentCustomer = null;
        foreach (Customers customer in customers)
        {
            if (customer != null && customer.CardNum == cardNum)
            {
                currentCustomer = customer;
                break;
            }
        }
        if (currentCustomer != null)
        {
            int pinCounter = 0;
            while (pinCounter<3) 
            {
                Console.WriteLine("Please enter your pin!");
                string pin = Console.ReadLine();
                if (currentCustomer.CheckPin(pin))
                {
                    return currentCustomer;
                }
                else 
                {
                    pinCounter++;
                    Console.WriteLine($"Invalid pin! You have {3-pinCounter} attempts left.");
                }
            }
            Console.WriteLine("Authentication failed! Please try again later.");
        }
        else { Console.WriteLine("Invalid card! Please try again."); }
    }
    else { Console.WriteLine("Invalid card! Please try again."); }
    return null;
}
static void RegisterCustomer(Customers[] customers)
{
    int index = Array.FindIndex(customers, c => c == null);

    if (index == -1)
    {
        Console.WriteLine("No space available to register a new customer.");
        return;
    }

    Console.Write("Enter first name: ");
    string firstName = Console.ReadLine();

    Console.Write("Enter last name: ");
    string lastName = Console.ReadLine();

    Console.Write("Enter new card number (e.g. 1234123412341234): ");
    string input = Console.ReadLine().Replace("-", "").Trim();

    if (!long.TryParse(input, out long cardNumber))
    {
        Console.WriteLine("Invalid card number format.");
        return;
    }

    if (customers.Any(c => c != null && c.CardNum == cardNumber))
    {
        Console.WriteLine("Card number already in use.");
        return;
    }

    Console.Write("Set your PIN: ");
    string pin = Console.ReadLine();

    Console.Write("Enter initial deposit: ");
    if (!double.TryParse(Console.ReadLine(), out double deposit) || deposit < 0)
    {
        Console.WriteLine("Invalid deposit amount.");
        return;
    }

    customers[index] = new Customers(firstName, lastName, cardNumber, pin, deposit);
    Console.WriteLine("Customer registered successfully.");
}