using System;

namespace snallWeeks_lab_firstDotNetApp
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Enter the series of '(' and ')': ");
      string input = Console.ReadLine(); // Input is treated as a string

      int floor = 0;

      // Loop through each character in the string
      foreach (char c in input)
      {
        if (c == '(')
        {
          floor += 1;  // Go up a floor
        }
        else if (c == ')')
        {
          floor -= 1;  // Go down a floor
        }
      }

      Console.WriteLine($"Santa ends up on floor: {floor}");
    }
  }
}
