using System;

class PingPong
{
  static void Main()

  {
    Console.WriteLine("Please enter a number.");
    string stringUserInput = Console.ReadLine();
    int inputNumber = int.Parse(stringUserInput);

    for (int i = 1; i <= inputNumber; i++)
    {
      if (i % 3 == 0 && i % 5 == 0)
      {
        Console.WriteLine("Ping Pong");
      }
      else if (i % 5 == 0)
      {
        Console.WriteLine("Pong");
      }
      else if (i % 3 == 0)
      {
        Console.WriteLine("Ping");
      }
      else
      {
        Console.WriteLine(i);
      }
    }
  }
}

