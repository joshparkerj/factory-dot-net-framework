using System;

namespace CS3450_Program04_JNP
{
    class LowResDisplayDriver : IDisplayDriver
    {
        private static LowResDisplayDriver uniqueInstance;

        public static LowResDisplayDriver GetInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new LowResDisplayDriver();
            return uniqueInstance;
        }

        public void Display(IDisplayable displayable)
        {
            Console.WriteLine($"Drawing {displayable.GetDisplayableType()}, {displayable.GetName()}, in low resolution");
        }

    }
}
