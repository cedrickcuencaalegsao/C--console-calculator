using System;

namespace CalculatorConsole
{
   class CalculatorConsole
   {
      static bool exit = false;

      public static void Main(string[] args)
      {
         while (!exit)
         {
            Menu();
            Console.Write("Option:> ");
            string input = Console.ReadLine();
            Console.WriteLine();

            switch (input)
            {
               case "+" or "Addition" or "addition" or "add":
                  Console.Write("Num 1:> ");
                  float add_1 = float.Parse(Console.ReadLine());

                  Console.Write("Num 2:> ");
                  float add_2 = float.Parse(Console.ReadLine());
                  Console.WriteLine();

                  // Call the Addition method with user input
                  float sum = Addition(add_1, add_2);
                  Console.WriteLine(add_1 + " " + "+" + " " + add_2 + " = " + sum);
                  Console.WriteLine();
                  break;

               case "-" or "Subtraction" or "subtraction" or "minus":
                  Console.Write("Num 1:> ");
                  float diff_1 = float.Parse(Console.ReadLine());

                  Console.Write("Num 2:> ");
                  float diff_2 = float.Parse(Console.ReadLine());
                  Console.WriteLine();

                  // Call the Addition method with user input
                  float differrence = Subtraction(diff_1, diff_2);
                  Console.WriteLine(diff_1 + " " + "+" + " " + diff_2 + " = " + differrence);
                  Console.WriteLine();
                  break;

               case "*" or "Multiplication" or "multiplication" or "multiply":
                  Console.Write("Num 1:> ");
                  float prod_1 = float.Parse(Console.ReadLine());

                  Console.Write("Num 2:> ");
                  float prod_2 = float.Parse(Console.ReadLine());
                  Console.WriteLine();

                  // Call the Addition method with user input
                  float product = Multiplication(prod_1, prod_2);
                  Console.WriteLine(prod_1 + " " + "+" + " " + prod_2 + " = " + product);
                  Console.WriteLine();
                  break;

               case "/" or "Division" or "division" or "divide":
                  Console.Write("Num 1:> ");
                  float quo_1 = float.Parse(Console.ReadLine());

                  Console.Write("Num 2:> ");
                  float quo_2 = float.Parse(Console.ReadLine());
                  Console.WriteLine();

                  // Call the Addition method with user input
                  float quotient = Division(quo_1, quo_2);
                  Console.WriteLine(quo_1 + " " + "+" + " " + quo_2 + " = " + quotient);
                  Console.WriteLine();
                  break;

               case "x" or "Exit" or "exit":
                  exit = true;
                  Console.WriteLine("Exiting...");
                  break;

               default:
                  Console.WriteLine("Invalid option. Please try again.");
                  break;

            }

         }
      }
      static void Menu()
      {
         Console.WriteLine();
         Console.WriteLine("==================================");
         Console.WriteLine("==      Console Calculator      ==");
         Console.WriteLine("==================================");
         Console.WriteLine(" [+] Addition");
         Console.WriteLine(" [-] Subtraction");
         Console.WriteLine(" [*] Multiplication");
         Console.WriteLine(" [/] Division");
         Console.WriteLine(" [x] Exit");
         Console.WriteLine("==================================");
         Console.WriteLine();
      }
      static float Addition(float Num_1, float Num_2)
      {
         float result = Num_1 + Num_2;
         return result;
      }
      static float Subtraction(float Num_1, float Num_2)
      {
         float result = Num_1 - Num_2;
         return result;
      }
      static float Multiplication(float Num_1, float Num_2)
      {
         float result = Num_1 * Num_2;
         return result;
      }
      static float Division(float Num_1, float Num_2)
      {
         float result = Num_1 / Num_2;
         return result;
      }
   }
}
