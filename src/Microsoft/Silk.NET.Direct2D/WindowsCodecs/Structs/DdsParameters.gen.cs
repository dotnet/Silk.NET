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
    [NativeName("Name", "WICDdsParameters")]
    public unsafe partial struct DdsParameters
    {
        public DdsParameters
        (
            uint? width = null,
            uint? height = null,
            uint? depth = null,
            uint? mipLevels = null,
            uint? arraySize = null,
            Silk.NET.DXGI.Format? dxgiFormat = null,
            DdsDimension? dimension = null,
            DdsAlphaMode? alphaMode = null
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

            if (depth is not null)
            {
                Depth = depth.Value;
            }

            if (mipLevels is not null)
            {
                MipLevels = mipLevels.Value;
            }

            if (arraySize is not null)
            {
                ArraySize = arraySize.Value;
            }

            if (dxgiFormat is not null)
            {
                DxgiFormat = dxgiFormat.Value;
            }

            if (dimension is not null)
            {
                Dimension = dimension.Value;
            }

            if (alphaMode is not null)
            {
                AlphaMode = alphaMode.Value;
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

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Depth")]
        public uint Depth;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MipLevels")]
        public uint MipLevels;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ArraySize")]
        public uint ArraySize;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "DxgiFormat")]
        public Silk.NET.DXGI.Format DxgiFormat;

        [NativeName("Type", "WICDdsDimension")]
        [NativeName("Type.Name", "WICDdsDimension")]
        [NativeName("Name", "Dimension")]
        public DdsDimension Dimension;

        [NativeName("Type", "WICDdsAlphaMode")]
        [NativeName("Type.Name", "WICDdsAlphaMode")]
        [NativeName("Name", "AlphaMode")]
        public DdsAlphaMode AlphaMode;
    }
}
