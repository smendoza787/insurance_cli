using System;

public class Cli
{
  public static string name;

  public static void printLogo()
  {                                                                                                  
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("`:+/.                    `:++-          `:/+:`");
    Console.WriteLine("/oooo+-`                 -oooo/`     `-/ooooo:");
    Console.WriteLine("/oo//oo+:`               -ooooo+. `-/+oo/-/oo:");
    Console.WriteLine("/oo: ./+o+:.             -oo+:/--/+oo+-`  /oo:");
    Console.WriteLine("/oo:   `:+oo/.           -o+-.:+oo+:`     /oo:");
    Console.WriteLine("/oo:     `-+oo+-`        `-:+oo+:-:/`     /oo:");
    Console.WriteLine("/oo:        ./oo+:`    `:+oo+:.  :oo+.    /oo:");
    Console.WriteLine("/oo:          ./+o+-`-/oo+/--     -+o+-   /oo:");
    Console.WriteLine("/oo:            `--/oo+/-./++      .+oo:  /oo:");
    Console.WriteLine("/oo:          `-/+oo+--:--oo+       `/oo/`/oo:");
    Console.WriteLine("/oo:        ./+oo+:` ./ooooo+         :oo++oo:");
    Console.WriteLine("/oo:     .:+oo+:.      ./+oo:          -+oooo:");
    Console.WriteLine("/oo:  .:+oo+:.           `.`            .+ooo-");
    Console.WriteLine("/oo/-+oo+/.                              `.-.");
    Console.WriteLine("/ooooo/-`");
    Console.WriteLine("./+/-`");
    Console.WriteLine();
    Console.WriteLine();
  }

  public static void getNameAndWelcome()
  {
    Console.WriteLine("Welcome to Vertafore Insurance!");
    Console.WriteLine();

    Console.WriteLine("Let's create a new profile...");
    Console.WriteLine();

    Console.Write("What is your name?: ");
    name = Console.ReadLine();

    Customer primary_customer = new Customer(name);

    Console.WriteLine("Awesome, nice to meet you {0}!", primary_customer.name);
  }

  public static void Main()
  {
    printLogo();
    getNameAndWelcome();
  }
}