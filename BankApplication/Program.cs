//Tiani  -- BIS 345
//Create a class for a banking account. Define subclasses for checkings and savings.

using System;

namespace BankApplication
{
    class Program
    {

        static void Main(string[] args)
        {
            BankAccount myObjBanking = new BankingAccount();
            myObjBanking.UserID = "tmjones3";

            Checkings myObjCheckings = new Checkings();
            myObjCheckings.Fee = 11;
            myObjCheckings.MinimumBalance = 50;
            myObjCheckings.AccountBal = 2500;

            Savings myObjSavings = new Savings();
            myObjSavings.AccountBal = 6421;
            myObjSavings.Rate = 3.0;
            myObjSavings.Amount = 1300;

            Console.WriteLine("Account: " + myObjBanking.UserID + "\n\n" + myObjCheckings + "\nBalance: $" 
                + myObjCheckings.AccountBal + "\n\n" + myObjSavings + "\nBalance: $" + myObjSavings.AccountBal + "\nInterest Rate: " + myObjSavings.Rate + "%");
        }

    }
}

