using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace CSharpSample {
    internal class FileManipulation {
        void DeleteFiles() {
            string[] sFiles = Directory.GetFiles("PATH", "*.*", SearchOption.AllDirectories);
            foreach (string s in sFiles)
                File.Delete(s);
        }

        void CopyFiles() {
            string[] sFiles = Directory.GetFiles("PATH", "*.*", SearchOption.AllDirectories);
            foreach (string s in sFiles) {
                FileInfo fi = new FileInfo(s);
                File.Copy(fi.FullName, "DEST");
            }
        }

        void WriteFiles() {
            using (StreamWriter sw = new StreamWriter("PATH")) {
                sw.BaseStream.Seek(0, SeekOrigin.Begin);
                sw.WriteLine("Hello World!");
            }
        }

        void ReadFiles() {
            using (StreamReader sr = new StreamReader("PATH")) {
                while (sr.Peek() != 0)
                    sr.ReadLine();
            }
        }

        void KillApps() {
            Process[] procs = Process.GetProcesses("gcad.exe");
            foreach (Process p in procs)
                p.Kill();
        }
    }
}
