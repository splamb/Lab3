using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();

            //Asks user for their name

            

            bool value = true;

            while(value == true)
            {
                Console.WriteLine(name + ", please type a number between 1 and 100");
                int num = int.Parse(Console.ReadLine());

                //Asks user for number input

                if (num < 1 || num > 100)
                {
                    Console.WriteLine(name + "'s input was invalid. Please type a number between 1 and 100.");
                    num = int.Parse(Console.ReadLine());
                }
                else
                {
                    if (num > 60 && num % 2 != 0)
                    {
                        Console.WriteLine(num + " and odd");
                    }
                    else if (num > 60 && num % 2 == 0)
                    {
                        Console.WriteLine(num + " and even");
                    }
                    else if (num < 25 && num % 2 == 0)
                    {
                        Console.WriteLine("Even and less than 25");
                    }
                    else if (num % 2 == 0)
                    {
                        Console.WriteLine("Even");
                    }
                    else
                    {
                        Console.WriteLine("Odd");
                    }

                    Console.WriteLine("Would you like to continue, " + name + "? (Input Y/N, case sensitive)");
                    string answer;
                    answer = Console.ReadLine();

                    if (answer == "Y")
                    {
                        value = true;
                    }
                    else
                    {
                        value = false;
                    }
                }
            } 

            Console.WriteLine("Thank you for using this program. Goodbye!");













        }
    }
}
