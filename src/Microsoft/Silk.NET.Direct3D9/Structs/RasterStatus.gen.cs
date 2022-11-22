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
    [NativeName("Name", "_D3DRASTER_STATUS")]
    public unsafe partial struct RasterStatus
    {
        public RasterStatus
        (
            Silk.NET.Core.Bool32? inVBlank = null,
            uint? scanLine = null
        ) : this()
        {
            if (inVBlank is not null)
            {
                InVBlank = inVBlank.Value;
            }

            if (scanLine is not null)
            {
                ScanLine = scanLine.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "InVBlank")]
        public Silk.NET.Core.Bool32 InVBlank;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ScanLine")]
        public uint ScanLine;
    }
}
