using System;
using Silk.NET.Windowing.Common;

namespace Silk.NET.Windowing.Desktop
{
    public class GlfwPlatform : ISilkPlatform
    {
        public bool IsApplicable => throw new NotImplementedException();

        public IWindow GetWindow(WindowOptions options)
        {
            return new GlfwWindow(options);
        }
    }
}