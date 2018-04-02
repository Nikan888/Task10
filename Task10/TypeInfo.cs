using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Task10
{
    public class TypeInfo
    {
        public static void MethodReflectInfo<T>(T obj) where T : class
        {
            Type t = typeof(T);
            MethodInfo[] MArr = t.GetMethods();
            Console.WriteLine("*** Список методов класса {0} ***\n", obj.ToString());
            
            foreach (MethodInfo m in MArr)
            {
                Console.Write(" --> " + m.ReturnType.Name + " \t" + m.Name + "(");
                ParameterInfo[] p = m.GetParameters();
                for (int i = 0; i < p.Length; i++)
                {
                    Console.Write(p[i].ParameterType.Name + " " + p[i].Name);
                    if (i + 1 < p.Length) Console.Write(", ");
                }
                Console.Write(")\n");
            }
        }
    }
}
