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

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_BITMAP_DATA_BGRA32")]
    public unsafe partial struct BitmapDataBgra32
    {
        public BitmapDataBgra32
        (
            uint? width = null,
            uint? height = null,
            uint* pixels = null
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

            if (pixels is not null)
            {
                Pixels = pixels;
            }
        }


        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "width")]
        public uint Width;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "height")]
        public uint Height;

        [NativeName("Type", "UINT32 *")]
        [NativeName("Type.Name", "UINT32 *")]
        [NativeName("Name", "pixels")]
        public uint* Pixels;
    }
}
