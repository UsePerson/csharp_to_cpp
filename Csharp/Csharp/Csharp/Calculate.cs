using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp
{
    public class Calculate
    {
        int a {
            get; set;
        }
        int b {
            get; set;
        }
        public Calculate(int a, int b) {
            this.a = a;
            this.b = b;
        }
        public Calculate() {
            a = 0;
            b = 0;
        }
        public int add() {
            return a + b;
        }
        public int div() {
            return a / b;
        }
        public int mod() {
            return a % b;
        }
        public int sub() {
            return a - b;
        }
        public int mul() {
            return a * b;
        }

        
    }
}
