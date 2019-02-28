/**
* IRenderFactory
* There are high res and low res implementations of this interface.
*/
namespace CS3450_Program04_JNP
{
    interface IRenderFactory
    {
        IPrintDriver GetPrintDriver();
        IDisplayDriver GetDisplayDriver();
    }
}
