<<<<<<< HEAD
﻿//Create a class for a banking account. Define subclasses for checkings and savings.
=======
//Create a class for a banking account. Define subclasses for checkings and savings.
>>>>>>> 8f1111f933c44b61e3b24f90f763aa89832f2ccb

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

