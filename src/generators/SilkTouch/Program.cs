using System;
using System.Diagnostics;
using System.Text.Json;
using Silk.NET.SilkTouch.Scraper.Subagent;

namespace SilkTouch
{
    internal class Program
    {
        public static string[] Args { get; internal set; }
        static int Main(string[] args)
        {
            Args = args;
            if (args.Length > 0 && args[0].ToLower() == "clangsharp")
            {
                return ClangSharpHandoff.RunClangSharp(args);
            }
            
            Console.WriteLine
            (
                "Silk.NET SilkTouch - "
                + $"v{typeof(Program).Assembly.GetName().Version?.ToString(3)} - " +
                "Copyright (c) .NET Foundation and Contributors"
            );

            var sw = new Stopwatch();
            
            sw.Stop();
            Console.WriteLine($"Concluded after {sw.Elapsed.TotalSeconds} seconds.");
            return 0;
        }
    }
}
