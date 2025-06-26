using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSample {
    internal class ClsDelegates {
        delegate void dg_Print(int val);

        void Print_Normal(int val) {
            Console.WriteLine(val);
        }

        void Print_Timesten(int val) {
            Console.WriteLine(val * 10);
        }

        void Print_Divideten(int val) {
            Console.WriteLine(val / 10);
        }

        void PrintHelper(dg_Print dgPrint, int val) {
            dgPrint(val);
        }

        void Main() {
            PrintHelper(Print_Normal, 100);
            PrintHelper(Print_Timesten, 100);
            PrintHelper(Print_Divideten, 100);
        }
    }
}
