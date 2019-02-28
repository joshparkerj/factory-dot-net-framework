/**
* IDisplayable
* An interface for the widget and future displayable objects if there were going to be any.
*/
namespace CS3450_Program04_JNP
{
    interface IDisplayable
    {
        void Draw();
        string GetName();
        string GetDisplayableType();
    }
}
