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
    [NativeName("Name", "D2D1_BITMAP_PROPERTIES1")]
    public unsafe partial struct BitmapProperties1
    {
        public BitmapProperties1
        (
            PixelFormat? pixelFormat = null,
            float? dpiX = null,
            float? dpiY = null,
            BitmapOptions? bitmapOptions = null,
            ID2D1ColorContext* colorContext = null
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

            if (bitmapOptions is not null)
            {
                BitmapOptions = bitmapOptions.Value;
            }

            if (colorContext is not null)
            {
                ColorContext = colorContext;
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

        [NativeName("Type", "D2D1_BITMAP_OPTIONS")]
        [NativeName("Type.Name", "D2D1_BITMAP_OPTIONS")]
        [NativeName("Name", "bitmapOptions")]
        public BitmapOptions BitmapOptions;

        [NativeName("Type", "ID2D1ColorContext *")]
        [NativeName("Type.Name", "ID2D1ColorContext *")]
        [NativeName("Name", "colorContext")]
        public ID2D1ColorContext* ColorContext;
    }
}
