using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass(7, 9);
            TypeInfo.MethodReflectInfo<TestClass>(testClass);
            Console.ReadKey();
        }
    }
}
