/**
* HighResPrintDriver
* This is a singleton.
* Its uniqueInstance is returned by the HighResRenderFactory's GetPrintDriver method.
*/
using System;

namespace CS3450_Program04_JNP
{
    class HighResPrintDriver : IPrintDriver
    {
        private static HighResPrintDriver uniqueInstance;

        public static HighResPrintDriver GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new HighResPrintDriver();
            return uniqueInstance;
        }

        public void Print(IPrintable printable)
        {
            Console.WriteLine($"Printing {printable.GetPrintableType()}, {printable.GetName()}, in high resolution.");
        }

    }
}
