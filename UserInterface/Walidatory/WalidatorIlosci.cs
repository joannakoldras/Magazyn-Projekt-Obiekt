using System;
using System.Collections.Generic;
using System.Text;

namespace UserInterface.Walidatory
{
    public static class WalidatorIlosci
    {
        public static bool CzyWiekszeOdZera(decimal value)
        {
            if (value >= 0)
                return true;
            else
                return false;
        }
    }
}
