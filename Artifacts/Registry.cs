using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirage_Security.Artifacts
{
    class Registry : Artifact
    {
        private List<string> keys;

        public Registry() : base()
        {
            keys = new List<string>();
        }

        public override void create()
        {
            IEnumerable<string> lines = File.ReadLines(Path.Combine(resDir, "registry.txt"));

            foreach (string line in lines)
            {
                try
                {
                    Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(line);
                    if (key == null)
                    {
                        key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(line);
                        key.Close();

                        keys.Add(line);
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
            foreach (string key in keys)
            {
                try
                {
                    Microsoft.Win32.Registry.LocalMachine.DeleteSubKey(key);
                }
                catch (Exception)
                {
                    //throw;
                }
            }

            keys.Clear();
        }
    }
}
