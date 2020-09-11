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
    [NativeName("Name", "D3DDISPLAYMODEEX")]
    public unsafe partial struct Displaymodeex
    {
        public Displaymodeex
        (
            uint size = default,
            uint width = default,
            uint height = default,
            uint refreshRate = default,
            Format format = default,
            Scanlineordering scanLineOrdering = default
        )
        {
            Size = size;
            Width = width;
            Height = height;
            RefreshRate = refreshRate;
            Format = format;
            ScanLineOrdering = scanLineOrdering;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Size")]
        public uint Size;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Width")]
        public uint Width;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Height")]
        public uint Height;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "RefreshRate")]
        public uint RefreshRate;

        [NativeName("Type", "D3DFORMAT")]
        [NativeName("Type.Name", "D3DFORMAT")]
        [NativeName("Name", "Format")]
        public Format Format;

        [NativeName("Type", "D3DSCANLINEORDERING")]
        [NativeName("Type.Name", "D3DSCANLINEORDERING")]
        [NativeName("Name", "ScanLineOrdering")]
        public Scanlineordering ScanLineOrdering;
    }
}
