using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Mirage_Security
{
    public class Artifacts
    {
        string baseDir;
        string resDir;
        string doNothingDir;

        List<string> files;
        List<string> directories;
        List<string> drivers;
        List<IntPtr> mutexes;
        List<int> pids;
        List<string> regKeys;

        public Artifacts()
        {
            baseDir = Application.StartupPath;
            resDir = Path.Combine(baseDir, "Resources");
            doNothingDir = Path.Combine(baseDir, "DoNothing.exe");

            files = new List<string>();
            directories = new List<string>();
            drivers = new List<string>();
            mutexes = new List<IntPtr>();
            pids = new List<int>();
            regKeys = new List<string>();
        }


        [DllImport("kernel32.dll")]
        public static extern IntPtr CreateMutex(IntPtr lpMutexAttributes, bool bInitialOwner, string lpName);

        [DllImport("kernel32.dll")]
        public static extern bool ReleaseMutex(IntPtr hMutex);


        private void createFilesFromList(string toCreate, List<string> toSave)
        {
            IEnumerable<string> fileNames = File.ReadLines(Path.Combine(resDir, toCreate));

            foreach (string file in fileNames)
            {
                try
                {
                    File.Copy(doNothingDir, file, false);
                    toSave.Add(file);
                }
                catch (Exception)
                {
                    //throw;
                }
            }
        }

        public void createMutex()
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

        public void removeMutex()
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

        public void createProcesses()
        {
            string temp = Path.GetTempPath();

            IEnumerable<string> processNames = File.ReadLines(Path.Combine(resDir, "processes.txt"));

            foreach (string name in processNames)
            {
                try
                {
                    string newFile = Path.Combine(temp, name);
                    File.Copy(doNothingDir, newFile, true);
                    pids.Add(Process.Start(newFile).Id);
                }
                catch (Exception)
                {
                    //throw;
                }
            }
        }

        public void endProcesses()
        {
            foreach (int p in pids)
            {
                try
                {
                    Process.GetProcessById(p).Kill();
                }
                catch (Exception)
                {
                    //throw;
                }
            }

            pids.Clear();
        }

        public void createRegistryArtifacts()
        {
            IEnumerable<string> lines = File.ReadLines(Path.Combine(resDir, "registry.txt"));

            foreach (string line in lines)
            {
                try
                {
                    RegistryKey key = Registry.LocalMachine.OpenSubKey(line);
                    if (key == null)
                    {
                        key = Registry.LocalMachine.CreateSubKey(line);
                        key.Close();

                        regKeys.Add(line);
                    }
                }
                catch (Exception)
                {
                    //throw;
                }
            }
        }

        public void removeRegistryArtifacts()
        {
            foreach (string key in regKeys)
            {
                try
                {
                    Registry.LocalMachine.DeleteSubKey(key);
                }
                catch (Exception)
                {
                    //throw;
                }
            }

            regKeys.Clear();
        }

        public void createFileArtifacts()
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

            createFilesFromList("files.txt", files);
        }

        public void removeFileArtifacts()
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

        public void createDrivers()
        {
            createFilesFromList("drivers.txt", drivers);
        }

        public void removeDrivers()
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
