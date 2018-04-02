using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    public class TestClass
    {
        int a, b;

        public TestClass(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int Multiply()
        {
            return (a * b);
        }

        public int Sum()
        {
            return (a + b);
        }

        public void ShowInfo()
        {
            Console.WriteLine(@"a = {0}, b = {1}", a, b);
        }

        public override string ToString()
        {
            return ("TestClass");
        }
    }
}
