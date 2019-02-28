namespace CS3450_Program04_JNP
{
    interface IRenderFactory
    {
        IPrintDriver GetPrintDriver();
        IDisplayDriver GetDisplayDriver();
    }
}
