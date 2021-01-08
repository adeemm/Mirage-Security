using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mirage_Security.Artifacts
{
    class Mutex : Artifact
    {
        private List<IntPtr> mutexes;

        public Mutex() : base()
        {
            mutexes = new List<IntPtr>();
        }


        [DllImport("kernel32.dll")]
        public static extern IntPtr CreateMutex(IntPtr lpMutexAttributes, bool bInitialOwner, string lpName);

        [DllImport("kernel32.dll")]
        public static extern bool ReleaseMutex(IntPtr hMutex);


        public override void create()
        {
            IEnumerable<string> lines = File.ReadLines(Path.Combine(resDir, "mutexes.txt"));

            foreach (string line in lines)
            {
                try
                {
                    IntPtr m = CreateMutex(IntPtr.Zero, false, line);
                    if (m != IntPtr.Zero)
                    {
                        mutexes.Add(m);
                    }
                }
                catch (Exception)
                {
                    //throw;
                }
            }
        }

        public override void remove()
        {
            foreach (IntPtr m in mutexes)
            {
                try
                {
                    ReleaseMutex(m);
                }
                catch (Exception)
                {
                    //throw;
                }
            }
        }
    }
}
