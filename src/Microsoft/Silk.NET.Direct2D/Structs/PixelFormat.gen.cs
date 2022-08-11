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
    [NativeName("Name", "D2D1_PIXEL_FORMAT")]
    public unsafe partial struct PixelFormat
    {
        public PixelFormat
        (
            Silk.NET.DXGI.Format? format = null,
            AlphaMode? alphaMode = null
        ) : this()
        {
            if (format is not null)
            {
                Format = format.Value;
            }

            if (alphaMode is not null)
            {
                AlphaMode = alphaMode.Value;
            }
        }


        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "D2D1_ALPHA_MODE")]
        [NativeName("Type.Name", "D2D1_ALPHA_MODE")]
        [NativeName("Name", "alphaMode")]
        public AlphaMode AlphaMode;
    }
}
