// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
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
            ushort? srcRectIndex = null,
            ushort? reserved = null,
            short? x = null,
            short? y = null
        ) : this()
        {
            if (srcRectIndex is not null)
            {
                SrcRectIndex = srcRectIndex.Value;
            }

            if (reserved is not null)
            {
                Reserved = reserved.Value;
            }

            if (x is not null)
            {
                X = x.Value;
            }

            if (y is not null)
            {
                Y = y.Value;
            }
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
