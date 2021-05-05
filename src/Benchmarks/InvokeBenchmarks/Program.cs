using System;
using System.Buffers.Binary;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using BenchmarkDotNet.Running;
using Silk.NET.Core.Native;

namespace InvokeBenchmarks
{
    class Program
    {
        static unsafe void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(Assembly.GetExecutingAssembly()).Run(args);
        }
    }
}
