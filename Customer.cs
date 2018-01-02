using System;

public class Customer
{
  public static int numCustomers = 0;
  public string name;
  public int id;
  public Customer(string n) {
    name = n;
    id = ++numCustomers;

    Console.WriteLine("YOUR NAME IS {0} AND YOUR ID IS {1}", name, id);
  }
}