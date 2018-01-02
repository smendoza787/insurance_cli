using System;

public class Cli
{
  public static string name;

  public static void getNameAndWelcome()
  {
    Console.WriteLine("Welcome to Vertafore Insurance!");
    Console.WriteLine();

    Console.WriteLine("Let's create a new profile...");
    Console.WriteLine();

    Console.Write("What is your name?: ");
    name = Console.ReadLine();

    Customer primary_customer = new Customer(name);

    // Console.WriteLine("Awesome, nice to meet you {0}", primary_customer.name);
  }

  public static void Main()
  {
    getNameAndWelcome();
  }
}