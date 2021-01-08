using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirage_Security.Artifacts
{
    class Process : Artifact
    {
        private List<int> pids;

        public Process() : base()
        {
            pids = new List<int>();
        }

        public override void create()
        {
            string temp = Path.GetTempPath();

            IEnumerable<string> processNames = File.ReadLines(Path.Combine(resDir, "processes.txt"));

            foreach (string name in processNames)
            {
                try
                {
                    string newFile = Path.Combine(temp, name);
                    File.Copy(doNothingDir, newFile, true);
                    pids.Add(System.Diagnostics.Process.Start(newFile).Id);
                }
                catch (Exception)
                {
                    //throw;
                }
            }
        }

        public override void remove()
        {
            foreach (int p in pids)
            {
                try
                {
                    System.Diagnostics.Process.GetProcessById(p).Kill();
                }
                catch (Exception)
                {
                    //throw;
                }
            }

            pids.Clear();
        }
    }
}
