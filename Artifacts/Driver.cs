using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirage_Security.Artifacts
{
    class Driver : Artifact
    {
        private List<string> drivers;

        public Driver() : base()
        {
            drivers = new List<string>();
        }

        public override void create()
        {
            IEnumerable<string> fileNames = File.ReadLines(Path.Combine(resDir, "drivers.txt"));

            foreach (string file in fileNames)
            {
                try
                {
                    File.Copy(doNothingDir, file, false);
                    drivers.Add(file);
                }
                catch (Exception)
                {
                    //throw;
                }
            }
        }

        public override void remove()
        {
            foreach (string driver in drivers)
            {
                try
                {
                    File.Delete(driver);
                }
                catch (Exception)
                {

                    //throw;
                }
            }

            drivers.Clear();
        }
    }
}
