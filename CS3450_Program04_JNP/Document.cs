/**
* Document 
* This is a stub class for demo purposes
* Depending on which type of print driver it receives in its constructor,
* it will either say it prints in high resolution or low resolution.
*/
namespace CS3450_Program04_JNP
{
    class Document : IPrintable
    {
        IPrintDriver printDriver;
        readonly string name;

        public Document(IPrintDriver p, string n)
        {
            printDriver = p;
            name = n;
        }

        public void Print()
        {
            printDriver.Print(this);
        }

        public string GetName()
        {
            return name;
        }

        public string GetPrintableType()
        {
            return "document";
        }

    }
}
