// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DCOMPOSERECTDESTINATION")]
    public unsafe partial struct Composerectdestination
    {
        public Composerectdestination
        (
            ushort srcRectIndex = default,
            ushort reserved = default,
            short x = default,
            short y = default
        )
        {
            SrcRectIndex = srcRectIndex;
            Reserved = reserved;
            X = x;
            Y = y;
        }


        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "SrcRectIndex")]
        public ushort SrcRectIndex;

        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "Reserved")]
        public ushort Reserved;

        [NativeName("Type", "SHORT")]
        [NativeName("Type.Name", "SHORT")]
        [NativeName("Name", "X")]
        public short X;

        [NativeName("Type", "SHORT")]
        [NativeName("Type.Name", "SHORT")]
        [NativeName("Name", "Y")]
        public short Y;
    }
}
