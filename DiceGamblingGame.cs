using System;

namespace DannyPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Random random = new Random();
                int num1 = 0;
                int num2 = 0;
                int min = 1;
                int max = 6;
                bool game = true;

                Console.WriteLine("------------------");
                Console.WriteLine("Dice Gambling Game");
                Console.WriteLine("------------------");

                num2 = random.Next(min, max + 1);

                    while (num1 != num2){

                    bool validInput = false;


                    while (!validInput)
                    {
                        Console.WriteLine("Enter the number you think will pop up (1-6): ");
                        if (int.TryParse(Console.ReadLine(), out num1) && num1 >= 1 && num1 <= 6)
                        {
                            validInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
                        }
                    }

                    if (num1 < num2)
                        {
                            Console.WriteLine("You Rolled: " + num1);
                            Console.WriteLine("I Rolled: " + num2);
                            Console.WriteLine("You Lost!");
                            Console.WriteLine("Ultimate Dice Lord Never Loses");
                        }

                        else if (num1 == num2)
                        {
                            Console.WriteLine("You Rolled: " + num1);
                            Console.WriteLine("I Rolled: " + num2);
                            Console.WriteLine("Can't believe we are equal");
                            Console.WriteLine("I'll get you next time");
                        }

                        else
                    {
                        Console.WriteLine("You Rolled: " + num1);
                        Console.WriteLine("I Rolled: " + num2);
                        Console.WriteLine("Hmmph, i Guess you won");
                        Console.WriteLine("I WILL NOT BE DEFEATED AGAIN!");
                    }

                        break;
                    }


            Console.WriteLine("Clear (Y/N): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.Write("Ultimate Dice Lord needs to sleep.....");
            Console.ReadKey();
        }
    }
}
