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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "D3DDISPLAYMODEFILTER")]
    public unsafe partial struct Displaymodefilter
    {
        public Displaymodefilter
        (
            uint? size = null,
            Format? format = null,
            Scanlineordering? scanLineOrdering = null
        ) : this()
        {
            if (size is not null)
            {
                Size = size.Value;
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
