using System;

namespace question06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the student's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the student's exam marks: ");
            int marks;
            if (Int32.TryParse(Console.ReadLine(), out marks))
            {
                if (marks >= 0 && marks <= 100)
                {
                    if (marks >= 75)
                    {
                        Console.WriteLine(name + " has received Grade A.");
                    }
                    else if (marks >= 60)
                    {
                        Console.WriteLine(name + " has received Grade B.");
                    }
                    else if (marks >= 50)
                    {
                        Console.WriteLine(name + " has received Grade C.");
                    }
                    else if (marks >= 40)
                    {
                        Console.WriteLine(name + " has received Grade D.");
                    }
                    else
                    {
                        Console.WriteLine(name + " has failed.");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR: Invalid marks");
                }
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}