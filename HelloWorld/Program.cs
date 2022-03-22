// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Enter A number: ");
//var number = System.Environment.MachineName;
//Console.WriteLine("Your Machine Name is " +number);
using System;
using System.Reflection.Metadata;
using HelloWorld.ClassConcept;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var name = System.Environment.MachineName;
            Console.WriteLine(name);
            Human human =new Human();
            human.canRun();
            AccType accType = new AccType();
            accType.setAccTypeDetails();
            accType.accHolderName="Vivek Owhal";
            accType.accNumber=112233;
            accType.getAccTypeDetails();
            //Console.WriteLine(accType.accHolderName);
        }
    }
}