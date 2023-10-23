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
    [NativeName("Name", "WICBitmapPlaneDescription")]
    public unsafe partial struct BitmapPlaneDescription
    {
        public BitmapPlaneDescription
        (
            Guid? format = null,
            uint? width = null,
            uint? height = null
        ) : this()
        {
            if (format is not null)
            {
                Format = format.Value;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }
        }


        [NativeName("Type", "WICPixelFormatGUID")]
        [NativeName("Type.Name", "WICPixelFormatGUID")]
        [NativeName("Name", "Format")]
        public Guid Format;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Width")]
        public uint Width;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Height")]
        public uint Height;
    }
}
