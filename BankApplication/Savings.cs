//Tiani  -- BIS 345
//Create a class for a banking account. Define subclasses for checkings and savings.

using System;

class Savings:BankAccount
{
    private double savingsAmount;
    private double interesetRate;

    public double Amount
    {
        get
        {
            return savingsAmount;
        }
        set
        {
            savingsAmount = value;
        }
    }

    public double Rate
    {
        get
        {
            return interesetRate;
        }
        set
        {
            interesetRate = value;
        }
    }

}
