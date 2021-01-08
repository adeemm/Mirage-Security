using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mirage_Security.Artifacts
{
    abstract class Artifact
    {
        protected string baseDir;
        protected string resDir;
        protected string doNothingDir;

        protected Artifact()
        {
            baseDir = Application.StartupPath;
            resDir = Path.Combine(baseDir, "Resources");
            doNothingDir = Path.Combine(baseDir, "DoNothing.exe");
        }

        public abstract void create();

        public abstract void remove();
    }
}
