// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "D3DDISPLAYMODEEX")]
    public unsafe partial struct Displaymodeex
    {
        public Displaymodeex
        (
            uint? size = null,
            uint? width = null,
            uint? height = null,
            uint? refreshRate = null,
            Format? format = null,
            Scanlineordering? scanLineOrdering = null
        ) : this()
        {
            if (size is not null)
            {
                Size = size.Value;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (refreshRate is not null)
            {
                RefreshRate = refreshRate.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (scanLineOrdering is not null)
            {
                ScanLineOrdering = scanLineOrdering.Value;
            }
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
