using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace InterfaceGUI
{
    class Interop
    {
        [DllImport("InterfaceHelper.dll", EntryPoint = "interfaceInit", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool interfaceInit();

        public Interop()
        {
            if (!Start())
                Loggging.Log.Get().Write("Could not start interface!", Loggging.Log.Level.DEBUG);
        }

        public bool Execute(Commands.Available C)
        {
            return true;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private bool Start()
        {
            AllocConsole();

            try
            {
                return interfaceInit();
            }

            catch (System.DllNotFoundException)
            {
                Loggging.Log.Get().Write("Could not load the interface DLL!", Loggging.Log.Level.PRODUCTION);
                return false;
            }
        }

        [DllImport("InterfaceHelper.dll", EntryPoint = "Connect", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool Connect(String C);

        public void _Connect(String comPort)
        {
            Connect(comPort);
        }
    }
}