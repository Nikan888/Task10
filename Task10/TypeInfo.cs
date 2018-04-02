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
            Console.WriteLine("/// Список методов класса {0} ///\n", obj.ToString());
            
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

        public static void ShowFieldPropertyInfo<T>(T obj) where T : class
        {
            Type t = typeof(T);
            Console.WriteLine("\n/// Поля (открытые) ///\n");
            FieldInfo[] fieldNames = t.GetFields();
            foreach (FieldInfo fil in fieldNames)
                Console.Write("--> " + fil.ReflectedType.Name + " " + fil.Name + "\n");
            Console.WriteLine("\n/// Свойства ///\n");
            PropertyInfo[] propertyNames = t.GetProperties();
            foreach (PropertyInfo prop in propertyNames)
                Console.Write("--> " + prop.ReflectedType.Name + " " + prop.Name + "\n");
        }

        public static void ShowInterfaceInfo<T>(T obj) where T : class
        {
            Type t = typeof(T);
            Console.WriteLine("\n/// Реализуемые интерфейсы ///\n");
            var im = t.GetInterfaces();
            foreach (Type tp in im)
                Console.WriteLine("--> " + tp.Name);
        }

        public static void ShowConstructorsinfo<T>(T obj) where T : class
        {
            Type t = typeof(T);
            Console.WriteLine("\n/// Конструкторы ///\n");
            ConstructorInfo[] ci = t.GetConstructors();
            foreach (ConstructorInfo c in ci)
            {
                Console.Write("-> " + c.Name + "(");
                ParameterInfo[] p = c.GetParameters();
                for (int i = 0; i < p.Length; i++)
                {
                    Console.Write(p[i].ParameterType.Name + " " + p[i].Name);
                    if (i + 1 < p.Length) Console.Write(", ");
                }
                Console.Write(")\n\n");
            }
        }
    }
}
