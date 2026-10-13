using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        // DSA Activity 5.1 - Rubi, Vince Paul Ronald

        Stack<int> numbers = new Stack<int>();
        int code = 0;

        while (code != 7)
        {
            Console.WriteLine("\nWelcome to my STACK PROGRAM");
            Console.WriteLine("Choose what you want to do?");
            Console.WriteLine("1 - PUSH");
            Console.WriteLine("2 - POP");
            Console.WriteLine("3 - SEARCH");
            Console.WriteLine("4 - PEEK");
            Console.WriteLine("5 - DISPLAY");
            Console.WriteLine("6 - COUNT");
            Console.WriteLine("7 - EXIT");
            Console.Write("Enter code: ");
            code = Convert.ToInt32(Console.ReadLine());

            if (code == 1)
            {
                Console.Write("Enter new data to push: ");
                int num = Convert.ToInt32(Console.ReadLine());
                numbers.Push(num);
                Console.WriteLine("New data has been added!");
            }
            else if (code == 2)
            {
                if (numbers.Count > 0)
                    Console.WriteLine("Popped: " + numbers.Pop());
                else
                    Console.WriteLine("Stack is empty.");
            }
            else if (code == 3)
            {
                Console.Write("Enter data to search: ");
                int num = Convert.ToInt32(Console.ReadLine());

                if (numbers.Contains(num))
                    Console.WriteLine("Data found.");
                else
                    Console.WriteLine("Data not found.");
            }
            else if (code == 4)
            {
                if (numbers.Count > 0)
                    Console.WriteLine("Top item: " + numbers.Peek());
                else
                    Console.WriteLine("Stack is empty.");
            }
            else if (code == 5)
            {
                Console.WriteLine("Stack Contents:");

                foreach (int item in numbers)
                {
                    Console.WriteLine(item);
                }
            }
            else if (code == 6)
            {
                Console.WriteLine("Number of items: " + numbers.Count);
            }
        }
        Console.WriteLine("Program terminated.");
    }
}