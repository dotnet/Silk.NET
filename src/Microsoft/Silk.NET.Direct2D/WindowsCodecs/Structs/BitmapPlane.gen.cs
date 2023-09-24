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
    [NativeName("Name", "WICBitmapPlane")]
    public unsafe partial struct BitmapPlane
    {
        public BitmapPlane
        (
            Guid? format = null,
            byte* pbBuffer = null,
            uint? cbStride = null,
            uint? cbBufferSize = null
        ) : this()
        {
            if (format is not null)
            {
                Format = format.Value;
            }

            if (pbBuffer is not null)
            {
                PbBuffer = pbBuffer;
            }

            if (cbStride is not null)
            {
                CbStride = cbStride.Value;
            }

            if (cbBufferSize is not null)
            {
                CbBufferSize = cbBufferSize.Value;
            }
        }


        [NativeName("Type", "WICPixelFormatGUID")]
        [NativeName("Type.Name", "WICPixelFormatGUID")]
        [NativeName("Name", "Format")]
        public Guid Format;

        [NativeName("Type", "BYTE *")]
        [NativeName("Type.Name", "BYTE *")]
        [NativeName("Name", "pbBuffer")]
        public byte* PbBuffer;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "cbStride")]
        public uint CbStride;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "cbBufferSize")]
        public uint CbBufferSize;
    }
}
