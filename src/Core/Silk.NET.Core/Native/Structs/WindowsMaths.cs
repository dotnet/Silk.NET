// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
