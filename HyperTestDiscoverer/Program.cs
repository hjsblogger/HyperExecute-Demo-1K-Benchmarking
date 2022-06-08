using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Reflection;
namespace HyperTestDiscoverer
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFrom(args[0]);
            foreach (Type type in assembly.GetTypes())
            {
                foreach (MethodInfo methodInfo in type.GetMethods())
                {
                    var attributes = methodInfo.GetCustomAttributes(true);
                    foreach (var attr in attributes)
                    {
                        if (attr.ToString() == "NUnit.Framework.TestAttribute")
                        {
                            var methodName = methodInfo.Name;
                            var fullName = methodInfo.DeclaringType.FullName;
                            Console.WriteLine(fullName + "." + methodName);
                        }
                    }
                }
            }
        }
    }
}
