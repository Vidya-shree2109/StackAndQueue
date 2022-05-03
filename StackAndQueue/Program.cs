using System;
namespace StackAndQueue;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("                                 WELCOME TO STACK AND QUEUE PROGRAM                                 ");
        StackOperation stack = new StackOperation();
        bool check = true;
        Console.WriteLine("1.Stack Creation\n2.Exit");
        while (check)
        {
            Console.WriteLine("\nEnter an option to execute: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    stack.Push(56);
                    stack.Push(30);
                    stack.Push(70);
                    stack.Display();
                    break;
                case 2:
                    check = false;
                    break;
            }
        }
    }
}