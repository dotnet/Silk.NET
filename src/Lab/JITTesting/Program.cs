using System;
using System.Runtime.InteropServices;
using Silk.NET.Core.Contexts;
using TestLib;

namespace JITTesting
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            var lib = new TestClass2();

            var a = Marshal.StringToHGlobalAnsi("Test 1");
            var b = Marshal.StringToHGlobalAnsi("Hello from SilkTouch!");
            lib.MessageBox(default, (char*) a, (char*) b, 0);

            lib.MessageBox(default, "Test 2", "Hello from SilkTouch!", 0);

            var x = stackalloc char[3];
            x[0] = 'H';
            x[1] = 'i';
            x[2] = '\0';
            
            lib.MessageBox(default, "Test 3", x, 0);

            // lib.MessageBox(default, "Test 4", 'H', 'i', '\0', 0);

            lib.MessageBox(default, "Test 5", new Span<char>((char*) b, 23), 0);

            lib.MessageBox(default, "Test 6", "Hello from SilkTouch!", true);
            lib.MessageBox(default, "Test 7", "Hello from SilkTouch!", false);
            lib.MessageBox<char>(default, "Test 8", new Span<char>((char*) b, 23), 0);
        }
    }
}
