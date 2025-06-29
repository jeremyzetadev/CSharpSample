using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CSharpSample {
    internal class MultiThreading {
        void Main() {
            for (int i = 0; i < 7; i++) {
                Thread th = new Thread(delegate () { Run(i); });
                th.Start();
                th.Join();
            }
        }

        void Run(int i) { 
            
        }
    }

    class AsyncTest {
        void Main() {
            Run();
        }

        async void Run() {
            Task<int> tsk = new Task<int>(RetVal);
            tsk.Start();

            int res = await tsk;
            Console.WriteLine(res);
        }

        int RetVal() {
            return 1;
        }
    }
}
