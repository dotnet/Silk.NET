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

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICImageParameters")]
    public unsafe partial struct ImageParameters
    {
        public ImageParameters
        (
            Silk.NET.Direct2D.PixelFormat? pixelFormat = null,
            float? dpiX = null,
            float? dpiY = null,
            float? top = null,
            float? left = null,
            uint? pixelWidth = null,
            uint? pixelHeight = null
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

            if (top is not null)
            {
                Top = top.Value;
            }

            if (left is not null)
            {
                Left = left.Value;
            }

            if (pixelWidth is not null)
            {
                PixelWidth = pixelWidth.Value;
            }

            if (pixelHeight is not null)
            {
                PixelHeight = pixelHeight.Value;
            }
        }


        [NativeName("Type", "D2D1_PIXEL_FORMAT")]
        [NativeName("Type.Name", "D2D1_PIXEL_FORMAT")]
        [NativeName("Name", "PixelFormat")]
        public Silk.NET.Direct2D.PixelFormat PixelFormat;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "DpiX")]
        public float DpiX;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "DpiY")]
        public float DpiY;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "Top")]
        public float Top;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "Left")]
        public float Left;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "PixelWidth")]
        public uint PixelWidth;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "PixelHeight")]
        public uint PixelHeight;
    }
}
