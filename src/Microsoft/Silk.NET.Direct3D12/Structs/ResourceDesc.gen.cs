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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RESOURCE_DESC")]
    public unsafe partial struct ResourceDesc
    {
        public ResourceDesc
        (
            ResourceDimension? dimension = null,
            ulong? alignment = null,
            ulong? width = null,
            uint? height = null,
            ushort? depthOrArraySize = null,
            ushort? mipLevels = null,
            Silk.NET.DXGI.Format? format = null,
            Silk.NET.DXGI.SampleDesc? sampleDesc = null,
            TextureLayout? layout = null,
            ResourceFlags? flags = null
        ) : this()
        {
            if (dimension is not null)
            {
                Dimension = dimension.Value;
            }

            if (alignment is not null)
            {
                Alignment = alignment.Value;
            }

            if (width is not null)
            {
                Width = width.Value;
            }

            if (height is not null)
            {
                Height = height.Value;
            }

            if (depthOrArraySize is not null)
            {
                DepthOrArraySize = depthOrArraySize.Value;
            }

            if (mipLevels is not null)
            {
                MipLevels = mipLevels.Value;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (sampleDesc is not null)
            {
                SampleDesc = sampleDesc.Value;
            }

            if (layout is not null)
            {
                Layout = layout.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "D3D12_RESOURCE_DIMENSION")]
        [NativeName("Type.Name", "D3D12_RESOURCE_DIMENSION")]
        [NativeName("Name", "Dimension")]
        public ResourceDimension Dimension;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Alignment")]
        public ulong Alignment;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Width")]
        public ulong Width;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Height")]
        public uint Height;

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "DepthOrArraySize")]
        public ushort DepthOrArraySize;

        [NativeName("Type", "UINT16")]
        [NativeName("Type.Name", "UINT16")]
        [NativeName("Name", "MipLevels")]
        public ushort MipLevels;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "DXGI_SAMPLE_DESC")]
        [NativeName("Type.Name", "DXGI_SAMPLE_DESC")]
        [NativeName("Name", "SampleDesc")]
        public Silk.NET.DXGI.SampleDesc SampleDesc;

        [NativeName("Type", "D3D12_TEXTURE_LAYOUT")]
        [NativeName("Type.Name", "D3D12_TEXTURE_LAYOUT")]
        [NativeName("Name", "Layout")]
        public TextureLayout Layout;

        [NativeName("Type", "D3D12_RESOURCE_FLAGS")]
        [NativeName("Type.Name", "D3D12_RESOURCE_FLAGS")]
        [NativeName("Name", "Flags")]
        public ResourceFlags Flags;
    }
}
