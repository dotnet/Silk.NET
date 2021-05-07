using System;
using Silk.NET.Windowing;

namespace Utf8Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = Window.Create(WindowOptions.Default);
            w.Title = "测试";
            w.Run();
        }
    }
}
