﻿namespace CS3450_Program04_JNP
{
    class LowResRenderFactory : IRenderFactory
    {

        public IPrintDriver GetPrintDriver()
        {
            return LowResPrintDriver.GetInstance();
        }

        public IDisplayDriver GetDisplayDriver()
        {
            return LowResDisplayDriver.GetInstance();
        }

    }
}
