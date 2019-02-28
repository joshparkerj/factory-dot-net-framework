/**
* Project Prolog
* Name: Josh Parker
* CS3450 Section 002
* Project: Program 4 - Factory Program
* Date: 02/27/2019 10:54 PM
* Disclaimer: This is my own work, not that of others.
* Purpose: Simulate a program that draws widgets and prints documents
* in the resolution specified in the res.ini file. Demonstrates the
* abstract factory pattern and the singleton pattern.
*/
using System;

namespace CS3450_Program04_JNP
{
    class Program
    {

        static void Main(string[] args)
        {
            ProgramDriver programDriver = new ProgramDriver();
            programDriver.InitializeRenderFactory();
            programDriver.HandleWidgets();
            programDriver.HandleDocuments();
            Console.WriteLine("\nStart interactive mode?\nPress Y to start\nPress any other key to quit");
            switch (Console.ReadKey().Key.ToString())
            {
                case "Y":
                    programDriver.Menu();
                    break;
                default:
                    break;
            }
        }

    }
}
