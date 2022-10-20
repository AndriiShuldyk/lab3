using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

class firstTask
{
    static void Main(string[] args)
    {
        Program first_task = new Program(1, 2);
        first_task.task();
    }
}

class strings
{
    public int firstString {get; set;}
    public int secondString {get; set;}
    public strings(int first_string, int second_string)
    {
        firstString = first_string;
        secondString = second_string;
    }
}

class Program : strings
{
    public Program(int first_string, int second_string) : base(first_string, second_string) { }

    public void task()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(firstString);
        Debug.WriteLine(firstString);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(secondString);
        Debug.WriteLine(secondString);
        Console.ForegroundColor = ConsoleColor.Black;
    }
}