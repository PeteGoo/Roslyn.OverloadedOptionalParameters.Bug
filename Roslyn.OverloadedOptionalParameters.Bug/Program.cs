using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roslyn.OverloadedOptionalParameters.Bug
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodToCall(null, null);
        }

        private static void MethodToCall(MyClass1 foo = null, MyClass2 bar = null)
        {
        }

        private static void MethodToCall(MyClass2 bar = null, MyClass1 qux = null, MyClass3 baz = null, MyClass4 waldo = null)
        {
        }

        private class MyClass1 { }
        private class MyClass2 { }
        private class MyClass3 { }
        private class MyClass4 { }
    }
}
