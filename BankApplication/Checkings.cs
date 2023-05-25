//Tiani  -- BIS 345
//Create a class for a banking account. Define subclasses for checkings and savings.

using System;
using System.Xml.Linq;
class Checkings:BankAccount
{
    private double minBalance;
    private double chkFees;

    public double MinimumBalance
    {
        get
        {
            return minBalance;
        }
        set
        {
            minBalance = value;
        }
    }

    public double Fee
    {
        get
        {
            return chkFees;
        }
        set
        {
            chkFees = value;
        }
    }
}