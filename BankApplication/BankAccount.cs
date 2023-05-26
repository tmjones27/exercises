//Create a class for a banking account. Define subclasses for checkings and savings.

using System;
abstract class BankAccount
{
    private string userId;
    private double balance;

    public string UserID
    {
        get
        {
            return userId;
        }
        set
        {
            userId = value;
        }
    }

    public double AccountBal
    {
        get
        {
            return balance;
        }
        set
        {
            balance = value;
        }
    }
}