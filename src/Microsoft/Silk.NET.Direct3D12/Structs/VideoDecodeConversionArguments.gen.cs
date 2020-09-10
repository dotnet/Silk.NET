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
    [NativeName("Name", "D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS")]
    public unsafe partial struct VideoDecodeConversionArguments
    {
        public VideoDecodeConversionArguments
        (
            int enable = default,
            ID3D12Resource* pReferenceTexture2D = default,
            uint referenceSubresource = default,
            Silk.NET.DXGI.ColorSpaceType outputColorSpace = default,
            Silk.NET.DXGI.ColorSpaceType decodeColorSpace = default
        )
        {
            Enable = enable;
            PReferenceTexture2D = pReferenceTexture2D;
            ReferenceSubresource = referenceSubresource;
            OutputColorSpace = outputColorSpace;
            DecodeColorSpace = decodeColorSpace;
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Enable")]
        public int Enable;

        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pReferenceTexture2D")]
        public ID3D12Resource* PReferenceTexture2D;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ReferenceSubresource")]
        public uint ReferenceSubresource;

        [NativeName("Type", "DXGI_COLOR_SPACE_TYPE")]
        [NativeName("Type.Name", "DXGI_COLOR_SPACE_TYPE")]
        [NativeName("Name", "OutputColorSpace")]
        public Silk.NET.DXGI.ColorSpaceType OutputColorSpace;

        [NativeName("Type", "DXGI_COLOR_SPACE_TYPE")]
        [NativeName("Type.Name", "DXGI_COLOR_SPACE_TYPE")]
        [NativeName("Name", "DecodeColorSpace")]
        public Silk.NET.DXGI.ColorSpaceType DecodeColorSpace;
    }
}
