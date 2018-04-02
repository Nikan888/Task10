using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    public class TestClass : ITestClass
    {
        int a, b;
        public double openField;

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }

        public TestClass(int a, int b)
        {
            this.A = a;
            this.B = b;
        }

        public int Multiply()
        {
            return (A * B);
        }

        public int Sum()
        {
            return (A + B);
        }

        public void ShowInfo()
        {
            Console.WriteLine(@"a = {0}, b = {1}", A, B);
        }

        public override string ToString()
        {
            return ("TestClass");
        }
    }
}
