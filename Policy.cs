using System;

public class Policy
{
  private static int total = 0;
  private int Id;
  public int CustomerId;
  public string Type;
  public DateTime StartDate;
  public DateTime EndDate;

  public Policy()
  {
    Id = ++total;
    CustomerId = 1;
  }
}