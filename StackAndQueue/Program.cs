using System;
namespace StackAndQueue;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("                                 WELCOME TO STACK AND QUEUE PROGRAM                                 ");
        StackOperation stack = new StackOperation();
        QueueOperation queue = new QueueOperation();
        bool check = true;
        Console.WriteLine("1.Stack Creation\n2.Peek And Pop From Stack\n3.Queue Operation\n4.Exit");
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
                    stack.Push(56);
                    stack.Push(30);
                    stack.Push(70);
                    stack.IsEmpty();
                    stack.Display();
                    break;
                case 3:
                    queue.Enqueue(56);
                    queue.Enqueue(30);
                    queue.Enqueue(70);
                    queue.Display();
                    break;
                case 4:
                    check = false;
                    break;
            }
        }
    }
}