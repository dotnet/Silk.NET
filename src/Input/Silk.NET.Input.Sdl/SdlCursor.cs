using System;
using Silk.NET.Core;

namespace Silk.NET.Input.Sdl
{
    public class SdlCursor : ICursor
    {
        public CursorType Type { get; set; }
        public StandardCursor StandardCursor { get; set; }
        public CursorMode CursorMode { get; set; }
        public int HotspotX { get; set; }
        public int HotspotY { get; set; }
        public RawImage Image { get; set; }
        public bool IsSupported(CursorMode mode)
        {
            throw new NotImplementedException();
        }

        public bool IsSupported(StandardCursor standardCursor)
        {
            throw new NotImplementedException();
        }
    }
}