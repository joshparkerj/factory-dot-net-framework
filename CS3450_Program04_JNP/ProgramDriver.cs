/**
* ProgramDriver
* Reads resolution setting from res.ini file.
* Reads widget names from Widgets.txt file.
* Reads document names from Documents.txt file.
* Displays all widgets and prints all documents.
*/
using System;
using System.Collections.Generic;
using System.IO;

namespace CS3450_Program04_JNP
{
    class ProgramDriver
    {
        private List<Widget> widgets;
        private List<Document> documents;
        ConsoleKeyInfo selection;
        IRenderFactory renderFactory;
        string resini;
        string[] widgetList;
        string[] documentList;

        public ProgramDriver()
        {
            widgets = new List<Widget>();
            documents = new List<Document>();
        }

        public void InitializeRenderFactory()
        {
            try
            {
                resini = File.ReadAllText("res.ini");
                if (resini == "High")
                {
                    Console.WriteLine("Got resolution from res.ini");
                    Console.WriteLine("Resolution set to high");
                    renderFactory = new HighResRenderFactory();
                }
                else if (resini == "Low")
                {
                    Console.WriteLine("Got resolution from res.ini");
                    Console.WriteLine("Resolution set to low");
                    renderFactory = new LowResRenderFactory();
                }
                else
                {
                    Console.WriteLine("res.ini file should read either High or Low. Setting resolution to low by default");
                    renderFactory = new LowResRenderFactory();
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("res.ini file not found. Setting resolution to low by default");
                renderFactory = new LowResRenderFactory();
            }
        }

        public void HandleWidgets()
        {
            Console.WriteLine("\nDrawing all widgets listed in Widgets.txt");
            try
            {
                widgetList = File.ReadAllLines("Widgets.txt");
                foreach (string widgetName in widgetList)
                {
                    widgets.Add(new Widget(renderFactory.GetDisplayDriver(), widgetName));
                }
                widgets.ForEach(widget => widget.Draw());
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Widgets.txt file not found.");
            }
        }

        public void HandleDocuments()
        {
            Console.WriteLine("\nPrinting all documents listed in Documents.txt");
            try
            {
                documentList = File.ReadAllLines("Documents.txt");
                foreach (string documentName in documentList)
                {
                    documents.Add(new Document(renderFactory.GetPrintDriver(), documentName));
                }
                documents.ForEach(document => document.Print());
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Documents.txt file not found.");
            }
        }

        public void Menu()
        {
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Please choose one of the following options:");
                Console.WriteLine("0: Clear Widget List");
                Console.WriteLine("1: Add New Widget");
                Console.WriteLine("2: Display Widgets");
                Console.WriteLine("3: Clear Document List");
                Console.WriteLine("4: Add New Document");
                Console.WriteLine("5: Print Documents");
                Console.WriteLine("Q: Quit Program");
                selection = Console.ReadKey();
                Console.WriteLine("\n");
                switch (selection.Key.ToString())
                {
                    case "D0":
                    case "NumPad0":
                        widgets.Clear();
                        Console.WriteLine("cleared");
                        break;
                    case "D1":
                    case "NumPad1":
                        Console.WriteLine("What's its name?");
                        widgets.Add(new Widget(renderFactory.GetDisplayDriver(), Console.ReadLine()));
                        break;
                    case "D2":
                    case "NumPad2":
                        widgets.ForEach(widget => widget.Draw());
                        break;
                    case "D3":
                    case "NumPad3":
                        documents.Clear();
                        Console.WriteLine("cleared");
                        break;
                    case "D4":
                    case "NumPad4":
                        Console.WriteLine("What's its name?");
                        documents.Add(new Document(renderFactory.GetPrintDriver(), Console.ReadLine()));
                        break;
                    case "D5":
                    case "NumPad5":
                        documents.ForEach(document => document.Print());
                        break;
                    case "Q":
                        break;
                    default:
                        Console.WriteLine("invalid input");
                        break;
                }
            } while (selection.Key.ToString() != "Q");
        }

    }
}
