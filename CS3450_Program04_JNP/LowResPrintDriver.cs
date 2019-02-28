using System;

namespace CS3450_Program04_JNP
{
    class LowResPrintDriver : IPrintDriver
    {
        private static LowResPrintDriver uniqueInstance;

        public static LowResPrintDriver GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new LowResPrintDriver();
            return uniqueInstance;
        }

        public void Print(IPrintable printable)
        {
            Console.WriteLine($"Printing {printable.GetPrintableType()}, {printable.GetName()}, in low resolution.");
        }

    }
}
