using System;

public class Cli
{
  public static string name;

  public static void printLogo()
  {                                                                                                  
    Console.WriteLine();
    Console.WriteLine("                       `:+/.                    `:++-          `:/+:`");
    Console.WriteLine("                       /oooo+-`                 -oooo/`     `-/ooooo:");
    Console.WriteLine("                       /oo//oo+:`               -ooooo+. `-/+oo/-/oo:");
    Console.WriteLine("                       /oo: ./+o+:.             -oo+:/--/+oo+-`  /oo:");
    Console.WriteLine("                       /oo:   `:+oo/.           -o+-.:+oo+:`     /oo:");
    Console.WriteLine("                       /oo:     `-+oo+-`        `-:+oo+:-:/`     /oo:");
    Console.WriteLine("                       /oo:        ./oo+:`    `:+oo+:.  :oo+.    /oo:");
    Console.WriteLine("                       /oo:          ./+o+-`-/oo+/--     -+o+-   /oo:");
    Console.WriteLine("                       /oo:            `--/oo+/-./++      .+oo:  /oo:");
    Console.WriteLine("                       /oo:          `-/+oo+--:--oo+       `/oo/`/oo:");
    Console.WriteLine("                       /oo:        ./+oo+:` ./ooooo+         :oo++oo:");
    Console.WriteLine("                       /oo:     .:+oo+:.      ./+oo:          -+oooo:");
    Console.WriteLine("                       /oo:  .:+oo+:.           `.`            .+ooo-");
    Console.WriteLine("                       /oo/-+oo+/.                              `.-.");
    Console.WriteLine("                       /ooooo/-`");
    Console.WriteLine("                       ./+/-`");
    Console.WriteLine();
    Console.WriteLine(" /$$    /$$                      /$$                /$$$$$$                             ");
    Console.WriteLine("| $$   | $$                     | $$               /$$__  $$                            ");
    Console.WriteLine("| $$   | $$ /$$$$$$   /$$$$$$  /$$$$$$    /$$$$$$ | $$  \\__//$$$$$$   /$$$$$$   /$$$$$$ ");
    Console.WriteLine("|  $$ / $$//$$__  $$ /$$__  $$|_  $$_/   |____  $$| $$$$   /$$__  $$ /$$__  $$ /$$__  $$");
    Console.WriteLine(" \\  $$ $$/| $$$$$$$$| $$  \\__/  | $$      /$$$$$$$| $$_/  | $$  \\ $$| $$  \\__/| $$$$$$$$");
    Console.WriteLine("  \\  $$$/ | $$_____/| $$        | $$ /$$ /$$__  $$| $$    | $$  | $$| $$      | $$_____/");
    Console.WriteLine("   \\  $/  |  $$$$$$$| $$        |  $$$$/|  $$$$$$$| $$    |  $$$$$$/| $$      |  $$$$$$$");
    Console.WriteLine("    \\_/    \\_______/|__/         \\___/   \\_______/|__/     \\______/ |__/       \\_______/ ");
    Console.WriteLine();
    Console.WriteLine();
  }

  public static string capitalize(string str)
  {
    return char.ToUpper(str[0]) + str.Substring(1);
  }

  public static void welcome()
  {
    Console.WriteLine("Welcome to Vertafore Insurance!");
    Console.WriteLine();

    Console.WriteLine("Let's get you started with a new insurance profile...");
    Console.WriteLine();

    Console.Write("What is your first name?: ");
    Customer primary_customer = new Customer(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine("Awesome, nice to meet you {0}!", capitalize(primary_customer.First_Name));
    Console.WriteLine();

    Console.Write("What is your last name?: ");
    primary_customer.Last_Name = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine("Okay {0} {1}, what kind of policy are you looking to create?", capitalize(primary_customer.First_Name), capitalize(primary_customer.Last_Name));
  }

  public static void Main()
  {
    printLogo();
    welcome();
  }
}