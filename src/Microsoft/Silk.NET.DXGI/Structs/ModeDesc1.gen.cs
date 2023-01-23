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

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_MODE_DESC1")]
    public unsafe partial struct ModeDesc1
    {
        public ModeDesc1
        (
            uint? width = null,
            uint? height = null,
            Silk.NET.DXGI.Rational? refreshRate = null,
            Silk.NET.DXGI.Format? format = null,
            ModeScanlineOrder? scanlineOrdering = null,
            ModeScaling? scaling = null,
            Silk.NET.Core.Bool32? stereo = null
        ) : this()
        {
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

            if (scanlineOrdering is not null)
            {
                ScanlineOrdering = scanlineOrdering.Value;
            }

            if (scaling is not null)
            {
                Scaling = scaling.Value;
            }

            if (stereo is not null)
            {
                Stereo = stereo.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Width")]
        public uint Width;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Height")]
        public uint Height;

        [NativeName("Type", "DXGI_RATIONAL")]
        [NativeName("Type.Name", "DXGI_RATIONAL")]
        [NativeName("Name", "RefreshRate")]
        public Silk.NET.DXGI.Rational RefreshRate;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "DXGI_MODE_SCANLINE_ORDER")]
        [NativeName("Type.Name", "DXGI_MODE_SCANLINE_ORDER")]
        [NativeName("Name", "ScanlineOrdering")]
        public ModeScanlineOrder ScanlineOrdering;

        [NativeName("Type", "DXGI_MODE_SCALING")]
        [NativeName("Type.Name", "DXGI_MODE_SCALING")]
        [NativeName("Name", "Scaling")]
        public ModeScaling Scaling;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Stereo")]
        public Silk.NET.Core.Bool32 Stereo;
    }
}
