using System;

public class Customer
{
  private static int numCustomers = 0;
  public string First_Name;
  public string Last_Name;
  public int id;

  public Customer(string n)
  {
    First_Name = n;
    id = ++numCustomers;
  }
}