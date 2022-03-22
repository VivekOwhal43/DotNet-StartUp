using System;
namespace HelloWorld.ClassConcept;
class AccType: Bank
{
    string accountType;
    public void setAccTypeDetails()
    {
        
        Console.WriteLine("Enter Account Type:");
        accountType=Console.ReadLine();
        //Convert.ToString(Console.ReadLine());
    }

    public void getAccTypeDetails()
    {
        Console.WriteLine("==========================");
        Console.WriteLine("Entered Details are");
        Console.WriteLine("Account Holder Name: "+accHolderName);
        Console.WriteLine("Account Number: "+accNumber);
        Console.WriteLine("Account Type:" +accountType);
        //accountType=Console.ReadLine();
        //Convert.ToString(Console.ReadLine());
    }
}
