// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
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
            ResourceDimension dimension = default,
            ulong alignment = default,
            ulong width = default,
            uint height = default,
            ushort depthOrArraySize = default,
            ushort mipLevels = default,
            Silk.NET.DXGI.Format format = default,
            Silk.NET.DXGI.SampleDesc sampleDesc = default,
            TextureLayout layout = default,
            ResourceFlags flags = default
        )
        {
            Dimension = dimension;
            Alignment = alignment;
            Width = width;
            Height = height;
            DepthOrArraySize = depthOrArraySize;
            MipLevels = mipLevels;
            Format = format;
            SampleDesc = sampleDesc;
            Layout = layout;
            Flags = flags;
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
