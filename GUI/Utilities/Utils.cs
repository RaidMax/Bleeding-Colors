using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace InterfaceGUI
{
    class Utils
    {
        public static int parseIntForTextbox(String input)
        {
            int newValue = -1;
            String cleanedStr = String.Empty;
            NumberStyles typeToParse = NumberStyles.None;

            foreach (char c in input)
            {
                if ((c > 47 && c < 58))
                    cleanedStr += c;

                else if((c > 64 && c < 71) || (c > 96 && c < 103))
                {
                    cleanedStr += c;
                    typeToParse = NumberStyles.HexNumber;
                }
            }

            int.TryParse(cleanedStr, typeToParse, CultureInfo.InvariantCulture, out newValue);

            if (newValue > -1 && newValue < 256)
                return (int)newValue;
            else
                return -1;
        }
    }
}
