/**
* IPrintable
* An interface for the document and future printable objects if there were going to be any.
*/
namespace CS3450_Program04_JNP
{
    interface IPrintable
    {
        void Print();
        string GetName();
        string GetPrintableType();
    }
}
