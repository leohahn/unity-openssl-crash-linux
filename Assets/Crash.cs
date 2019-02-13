using System.Runtime.InteropServices;

namespace DefaultNamespace
{
    public class Crash
    {
        #if UNITY_IPHONE
        private const string LibName = "__Internal";
        #else
        private const string LibName = "libcrash";
        #endif

        [DllImport(LibName, EntryPoint = "crash")]
        public static extern void CrashFunction(string ca_string);
    }
}