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
    [NativeName("Name", "D2D1_BITMAP_PROPERTIES")]
    public unsafe partial struct BitmapProperties
    {
        public BitmapProperties
        (
            PixelFormat? pixelFormat = null,
            float? dpiX = null,
            float? dpiY = null
        ) : this()
        {
            if (pixelFormat is not null)
            {
                PixelFormat = pixelFormat.Value;
            }

            if (dpiX is not null)
            {
                DpiX = dpiX.Value;
            }

            if (dpiY is not null)
            {
                DpiY = dpiY.Value;
            }
        }


        [NativeName("Type", "D2D1_PIXEL_FORMAT")]
        [NativeName("Type.Name", "D2D1_PIXEL_FORMAT")]
        [NativeName("Name", "pixelFormat")]
        public PixelFormat PixelFormat;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "dpiX")]
        public float DpiX;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "dpiY")]
        public float DpiY;
    }
}
