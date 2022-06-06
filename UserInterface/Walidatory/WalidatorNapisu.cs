using System;
using System.Collections.Generic;
using System.Text;

namespace UserInterface.Walidatory
{
    public static class WalidatorNapisu
    {
        public static bool CzyNapisNieJestPusty(string value)
        {
            if (value == null || value.Length == 0)
                return false;
            else
                return true;
        }
    }
}
