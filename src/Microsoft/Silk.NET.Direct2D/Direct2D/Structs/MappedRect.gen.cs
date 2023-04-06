// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_MAPPED_RECT")]
    public unsafe partial struct MappedRect
    {
        public MappedRect
        (
            uint? pitch = null,
            byte* bits = null
        ) : this()
        {
            if (pitch is not null)
            {
                Pitch = pitch.Value;
            }

            if (bits is not null)
            {
                Bits = bits;
            }
        }


        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "pitch")]
        public uint Pitch;

        [NativeName("Type", "BYTE *")]
        [NativeName("Type.Name", "BYTE *")]
        [NativeName("Name", "bits")]
        public byte* Bits;
    }
}
