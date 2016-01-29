using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceGUI
{
    class Manager
    {
        public void Start()
        {
            DllConnection = new Interop();
            Storage = new StorageArchitecture();
        }

        public static Interop DllConnection;
        public static StorageArchitecture Storage;
        public static String comPort;
    }
}
