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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "CD3D11_TEXTURE2D_DESC")]
    public unsafe partial struct CD3D11Texture2DDesc
    {
        public CD3D11Texture2DDesc
        (
            uint width = default,
            uint height = default,
            uint mipLevels = default,
            uint arraySize = default,
            Silk.NET.DXGI.Format format = default,
            Silk.NET.DXGI.SampleDesc sampleDesc = default,
            Usage usage = default,
            uint bindFlags = default,
            uint cPUAccessFlags = default,
            uint miscFlags = default
        )
        {
            Width = width;
            Height = height;
            MipLevels = mipLevels;
            ArraySize = arraySize;
            Format = format;
            SampleDesc = sampleDesc;
            Usage = usage;
            BindFlags = bindFlags;
            CPUAccessFlags = cPUAccessFlags;
            MiscFlags = miscFlags;
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
        [NativeName("Name", "MipLevels")]
        public uint MipLevels;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ArraySize")]
        public uint ArraySize;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "DXGI_SAMPLE_DESC")]
        [NativeName("Type.Name", "DXGI_SAMPLE_DESC")]
        [NativeName("Name", "SampleDesc")]
        public Silk.NET.DXGI.SampleDesc SampleDesc;

        [NativeName("Type", "D3D11_USAGE")]
        [NativeName("Type.Name", "D3D11_USAGE")]
        [NativeName("Name", "Usage")]
        public Usage Usage;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BindFlags")]
        public uint BindFlags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "CPUAccessFlags")]
        public uint CPUAccessFlags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "MiscFlags")]
        public uint MiscFlags;
    }
}
