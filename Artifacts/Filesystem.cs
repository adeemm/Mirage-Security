using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirage_Security.Artifacts
{
    class Filesystem : Artifact
    {
        private List<string> files;
        private List<string> directories;

        public Filesystem() : base()
        {
            files = new List<string>();
            directories = new List<string>();
        }

        public override void create()
        {
            IEnumerable<string> dirNames = File.ReadLines(Path.Combine(resDir, "directories.txt"));

            foreach (string dir in dirNames)
            {
                try
                {
                    Directory.CreateDirectory(dir);
                    directories.Add(dir);
                }
                catch (Exception)
                {
                    //throw;
                }
            }

            IEnumerable<string> fileNames = File.ReadLines(Path.Combine(resDir, "files.txt"));

            foreach (string file in fileNames)
            {
                try
                {
                    File.Copy(doNothingDir, file, false);
                    files.Add(file);
                }
                catch (Exception)
                {
                    //throw;
                }
            }
        }

        public override void remove()
        {
            foreach (string file in files)
            {
                try
                {
                    File.Delete(file);
                }
                catch (Exception)
                {
                    //throw;
                }
            }

            foreach (string dir in directories)
            {
                try
                {
                    Directory.Delete(dir);
                }
                catch (Exception)
                {
                    //throw;
                }
            }

            files.Clear();
            directories.Clear();
        }
    }
}
