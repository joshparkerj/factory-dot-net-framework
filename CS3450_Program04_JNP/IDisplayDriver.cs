/**
* IDisplayDriver 
* The only displayable object I've implemented is the widget,
* but I programmed to an interface in any case.
*/
namespace CS3450_Program04_JNP
{
    interface IDisplayDriver
    {
        void Display(IDisplayable displayable);
    }
}
