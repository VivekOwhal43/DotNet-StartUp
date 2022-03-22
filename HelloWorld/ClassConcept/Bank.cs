using System.Xml.Serialization;
using System;
using System.Security.Cryptography.X509Certificates;
namespace HelloWorld.ClassConcept;
class Bank
{
    public string accHolderName = "Vivek"; //accountType;
    public int accNumber;
    public void getBankDetails()
    {
        Console.WriteLine(accHolderName);
    }
}