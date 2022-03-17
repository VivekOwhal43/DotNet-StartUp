// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Enter A number: ");
//var number = System.Environment.MachineName;
//Console.WriteLine("Your Machine Name is " +number);
using System;
using System.Reflection.Metadata;

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
        }
    }
}