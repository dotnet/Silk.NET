// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Reflection;
using BenchmarkDotNet.Running;

namespace Silk.NET.Maths.Benchmark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(Assembly.GetEntryAssembly()).Run(args);
        }
    }
}