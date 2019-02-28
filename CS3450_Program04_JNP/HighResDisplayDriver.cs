/**
* HighResDisplayDriver
* This is a singleton.
* Its uniqueInstance is returned by the HighResRenderFactory's GetDisplayDriver method.
*/
using System;

namespace CS3450_Program04_JNP
{
    class HighResDisplayDriver : IDisplayDriver
    {
        private static HighResDisplayDriver uniqueInstance;

        public static HighResDisplayDriver GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new HighResDisplayDriver();
            return uniqueInstance;
        }

        public void Display(IDisplayable displayable)
        {
            Console.WriteLine($"Drawing {displayable.GetDisplayableType()}, {displayable.GetName()}, in high resolution");
        }

    }
}
