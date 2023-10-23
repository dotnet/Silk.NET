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
    [NativeName("Name", "WICDdsFormatInfo")]
    public unsafe partial struct DdsFormatInfo
    {
        public DdsFormatInfo
        (
            Silk.NET.DXGI.Format? dxgiFormat = null,
            uint? bytesPerBlock = null,
            uint? blockWidth = null,
            uint? blockHeight = null
        ) : this()
        {
            if (dxgiFormat is not null)
            {
                DxgiFormat = dxgiFormat.Value;
            }

            if (bytesPerBlock is not null)
            {
                BytesPerBlock = bytesPerBlock.Value;
            }

            if (blockWidth is not null)
            {
                BlockWidth = blockWidth.Value;
            }

            if (blockHeight is not null)
            {
                BlockHeight = blockHeight.Value;
            }
        }


        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "DxgiFormat")]
        public Silk.NET.DXGI.Format DxgiFormat;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BytesPerBlock")]
        public uint BytesPerBlock;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BlockWidth")]
        public uint BlockWidth;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BlockHeight")]
        public uint BlockHeight;
    }
}
