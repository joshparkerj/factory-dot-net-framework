/**
* Widget 
* This is a stub class for demo purposes
* Depending on which type of display driver it receives in its constructor,
* it will either say it draws in high resolution or low resolution.
*/
namespace CS3450_Program04_JNP
{
    class Widget : IDisplayable
    {
        IDisplayDriver displayDriver;
        readonly string name;

        public Widget(IDisplayDriver d, string n)
        {
            displayDriver = d;
            name = n;
        }

        public void Draw()
        {
            displayDriver.Display(this);
        }

        public string GetName()
        {
            return name;
        }

        public string GetDisplayableType()
        {
            return "widget";
        }

    }
}
