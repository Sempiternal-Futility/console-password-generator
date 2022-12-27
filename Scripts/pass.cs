using System;

class Program
{
  static bool loopSwitch;

  static void Main()
  {
      Console.Clear();
  
      char[] passChars = { '!', '@', '#', '$', '%', '^', '&', '*', 
                            '1', '2', '3', '4', '5', '6', '7', 
                             'A', 'b', 'c', 'd', 'E', 'f', 'g', 'H', 'i', 'f', 'g'};


      Console.ForegroundColor = ConsoleColor.Cyan; 
      Console.Write("PASSWORD: ");
      Console.ForegroundColor = ConsoleColor.Red;

      for ( int i = new Random().Next(5, 25);  i >= 0; i--)
      {
          Console.Write(passChars[i]);
      }


      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("      DON'T SHARE IT WITH ANYONE!!!");
      Console.ReadKey(true);

      Console.WriteLine("Do you want to try another password? y/n");

      loopSwitch = true;

      while(loopSwitch)
      {

       switch (Console.ReadKey(true).KeyChar)
       {
          case 'y' : Main(); loopSwitch = false;
          break;

          case 'n' : loopSwitch = false;
          break;

          default : loopSwitch = true;
          break;
       }
    
      }
  }
}
