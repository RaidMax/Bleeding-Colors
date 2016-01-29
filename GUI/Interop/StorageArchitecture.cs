using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceGUI
{
    class StorageArchitecture
    {
        public StorageArchitecture()
        {
            currentColors = new int[3] { 0, 0, 0 };
        }

        public int[] currentColors { set; get; }
    }
}
