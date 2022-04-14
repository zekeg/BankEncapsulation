using System;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount() {}
        private double balance = 0;
        public void Deposit(double depnum) {
            balance += depnum;
        }
        public double GetBalance() {
            return balance;
        }
    }
    class Program
    { 
       
        static void Main(string[] args)
        {
            //instantiate a new BankAccount class
           BankAccount userAcount = new BankAccount();

            string userEntry = "void";
            //the program runs until the user exits
            while (userEntry != "exit")
            {
                //Prompt the user to enter a text option
                Console.WriteLine("\n\nHello, please select an option:");
                Console.WriteLine("\nType 'balance' to check your balance\nType 'deposit' to deposit into your account\nType 'exit' to quit");

                //Collect user entry
                userEntry = Console.ReadLine();

                //check if user entry is deposit, balance or exit
                if (userEntry == "balance")
                {
                    Console.WriteLine($"Your balance is: {userAcount.GetBalance()}");
                    Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _");
                }
                else if (userEntry == "deposit")
                {
                    string depositAmountString;
                    double depositAmount;
                    bool isValid = false;

                    while(isValid == false){
                        Console.WriteLine("Please enter the numerical amount you'd like to deposit or type 'exit':");
                        depositAmountString = Console.ReadLine();
                        isValid = double.TryParse(depositAmountString, out depositAmount);

                        if (depositAmountString == "exit") {
                            Console.WriteLine("\n\nReturning to main menu...");
                            isValid = true;
                        }
                        if (isValid == true) {
                            userAcount.Deposit(depositAmount);
                            Console.WriteLine($"Your new balance is: {userAcount.GetBalance()}\nReturning to main menu...");
                            Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _");
                        }
                        
                    }
                }
            }
       
        }
    }

}
