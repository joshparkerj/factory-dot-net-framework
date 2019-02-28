/**
* HighResRenderFactory
* This is the implementation that will be newed up if the res.ini file says High.
*/
namespace CS3450_Program04_JNP
{
    class HighResRenderFactory : IRenderFactory
    {

        public IPrintDriver GetPrintDriver()
        {
            return HighResPrintDriver.GetInstance();
        }

        public IDisplayDriver GetDisplayDriver()
        {
            return HighResDisplayDriver.GetInstance();
        }

    }
}
