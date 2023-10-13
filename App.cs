using System;

public class Program
{
   public static void Main(string[] args)
   {
      Console.WriteLine("Select conversion: \n 1 - Celcius \n 2 - Kelvin \n 3 - Farenheit \n 4 - Reamur");


      // Input temperature
      Console.Write(">>> Select Temperature: ");
      string input = Console.ReadLine();
      int select = Convert.ToInt32(input);


      // Switch for selected temperature
      switch (select)
      {
         case 1:
            Console.WriteLine("Selected Celcius");
            break;
         case 2:
            Console.WriteLine("Selected Kelvin");
            break;
         case 3:
            Console.WriteLine("Selected Farenheit");
            break;
         case 4:
            Console.WriteLine("Selected Reamur");
            break;
         default:
            Console.WriteLine("Please select the correct input");
            Environment.Exit(1);
            break;
      }


      Console.WriteLine("");


      // Input value that want to be converted
      Console.Write(">>> Input Value: ");
      string value = Console.ReadLine();
      double num = Convert.ToInt32(value);


      // Conversion logic
      switch (select)
      {
         case 1:
            Console.WriteLine("Celcius to Kelvin: " + (num + 273));
            Console.WriteLine("Celcius to Farenheit: " + ((num * 9 / 5) + 32));
            Console.WriteLine("Celcius to Reamur: " + (num * 4 / 5));
            break;
         case 2:
            Console.WriteLine("Kelvin to Celcius: " + (num - 273));
            Console.WriteLine("Kelvin to Farenheit: " + ((num - 273) * 9 / 5 + 32));
            Console.WriteLine("Kelvin to Reamur: " + ((num - 273) * 4 / 5));
            break;
         case 3:
            Console.WriteLine("Farenheit to Celcius: " + ((num - 32) * 5 / 9));
            Console.WriteLine("Farenheit to Kelvin: " + ((num - 32) * 5 / 9 + 273));
            Console.WriteLine("Farenheit to Reamur: " + ((num - 32) * 4 / 9));
            break;
         case 4:
            Console.WriteLine("Reamur to Celcius: " + (5 / 4 * num));
            Console.WriteLine("Reamur to Kelvin: " + (9 / 4 * num + 32));
            Console.WriteLine("Reamur to Farenheit: " + (5 / 4 * num + 273));
            break;
      }
   }
}
