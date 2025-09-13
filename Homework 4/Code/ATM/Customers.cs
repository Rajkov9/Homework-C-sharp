using System.Security.Cryptography.X509Certificates;

namespace ATM
{
    public class Customers
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long CardNum { get; set; }
        private string Pin { get; set; }
        private double Balance { get; set; }

        public Customers(string firstName, string lastName, long cardNum, string pin, double balance)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNum = cardNum;
            Pin = pin;
            Balance = balance;
        }
        public void CashWithdrawal(double funds)
        {
            if (funds <= Balance) 
            {
              Balance -= funds;
                Console.WriteLine($"You have succesfully withdrawan ${funds}.");
                Console.WriteLine($"You currently have ${Balance} left in your account.");
            }
            else { Console.WriteLine("Not enough funds!"); }
        }
        public void CashDeposit(double funds)
        {
            Balance += funds;
            Console.WriteLine($"You currently have ${Balance} in your account.");
        }
        public double GetBalance() { return Balance; }
        public bool CheckPin(string pin) { return Pin==pin; }
    }
}