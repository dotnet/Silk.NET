// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Core.Native
{
    public struct TagRect
    {
        public long Left, Top, Right, Bottom;
    }
    
    public struct TagPoint
    {
        public long X, Y;
    }
    
    public struct TagSize
    {
        public long Width, Height;
    }

    public struct TagPaletteEntry
    {
        public byte PeRed;
        public byte PeGreen;
        public byte PeBlue;
        public byte PeFlags;
    }
}
