using System;

namespace Geodex
{
    public class KopernicusChecker
    {
        private bool _kopExists = false;
        Object Kopernicus, KopernicusParser, KopernicusComponents, KopernicusOnDemand;
        
        Kopernicus = CreateObject("Kopernicus");
        KopernicusParser = CreateObject("Kopernicus");
        public static bool KopExists
        {
            get
            {
                return _kopExists;
            }
            set
            {
                if(Assembly.LoadedAssemblies.Contains("Kopernicus"))
            }
        }
    }
}
