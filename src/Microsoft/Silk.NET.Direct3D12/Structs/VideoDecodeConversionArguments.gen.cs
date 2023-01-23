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
    [NativeName("Name", "D3D12_VIDEO_DECODE_CONVERSION_ARGUMENTS")]
    public unsafe partial struct VideoDecodeConversionArguments
    {
        public VideoDecodeConversionArguments
        (
            Silk.NET.Core.Bool32? enable = null,
            ID3D12Resource* pReferenceTexture2D = null,
            uint? referenceSubresource = null,
            Silk.NET.DXGI.ColorSpaceType? outputColorSpace = null,
            Silk.NET.DXGI.ColorSpaceType? decodeColorSpace = null
        ) : this()
        {
            if (enable is not null)
            {
                Enable = enable.Value;
            }

            if (pReferenceTexture2D is not null)
            {
                PReferenceTexture2D = pReferenceTexture2D;
            }

            if (referenceSubresource is not null)
            {
                ReferenceSubresource = referenceSubresource.Value;
            }

            if (outputColorSpace is not null)
            {
                OutputColorSpace = outputColorSpace.Value;
            }

            if (decodeColorSpace is not null)
            {
                DecodeColorSpace = decodeColorSpace.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Enable")]
        public Silk.NET.Core.Bool32 Enable;

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
