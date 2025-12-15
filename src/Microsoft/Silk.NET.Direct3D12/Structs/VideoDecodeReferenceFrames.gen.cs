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
    [NativeName("Name", "D3D12_VIDEO_DECODE_REFERENCE_FRAMES")]
    public unsafe partial struct VideoDecodeReferenceFrames
    {
        public VideoDecodeReferenceFrames
        (
            uint? numTexture2Ds = null,
            ID3D12Resource** ppTexture2Ds = null,
            uint* pSubresources = null,
            ID3D12VideoDecoderHeap** ppHeaps = null
        ) : this()
        {
            if (numTexture2Ds is not null)
            {
                NumTexture2Ds = numTexture2Ds.Value;
            }

            if (ppTexture2Ds is not null)
            {
                PpTexture2Ds = ppTexture2Ds;
            }

            if (pSubresources is not null)
            {
                PSubresources = pSubresources;
            }

            if (ppHeaps is not null)
            {
                PpHeaps = ppHeaps;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumTexture2Ds")]
        public uint NumTexture2Ds;

        [NativeName("Type", "ID3D12Resource **")]
        [NativeName("Type.Name", "ID3D12Resource **")]
        [NativeName("Name", "ppTexture2Ds")]
        public ID3D12Resource** PpTexture2Ds;

        [NativeName("Type", "UINT *")]
        [NativeName("Type.Name", "UINT *")]
        [NativeName("Name", "pSubresources")]
        public uint* PSubresources;

        [NativeName("Type", "ID3D12VideoDecoderHeap **")]
        [NativeName("Type.Name", "ID3D12VideoDecoderHeap **")]
        [NativeName("Name", "ppHeaps")]
        public ID3D12VideoDecoderHeap** PpHeaps;
    }
}
