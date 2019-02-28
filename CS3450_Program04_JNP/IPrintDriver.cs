/**
* IPrintDriver
* The only printable object I've implemented is the document,
* but I programmed to an interface in any case.
*/
namespace CS3450_Program04_JNP
{
    interface IPrintDriver
    {
        void Print(IPrintable printable);
    }
}
