using System.Runtime.InteropServices;

namespace Silk.NET.Core
{
    [StructLayout(LayoutKind.Auto)]
    public struct WindowHandles
    {
        public bool IsSupported { get; }
        // ...
    }
}