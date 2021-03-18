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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_VIDEO_DECODER_BUFFER_DESC1")]
    public unsafe partial struct VideoDecoderBufferDesc1
    {
        public VideoDecoderBufferDesc1
        (
            VideoDecoderBufferType? bufferType = null,
            uint? dataOffset = null,
            uint? dataSize = null,
            void* pIV = null,
            uint? iVSize = null,
            VideoDecoderSubSampleMappingBlock* pSubSampleMappingBlock = null,
            uint? subSampleMappingCount = null
        ) : this()
        {
            if (bufferType is not null)
            {
                BufferType = bufferType.Value;
            }

            if (dataOffset is not null)
            {
                DataOffset = dataOffset.Value;
            }

            if (dataSize is not null)
            {
                DataSize = dataSize.Value;
            }

            if (pIV is not null)
            {
                PIV = pIV;
            }

            if (iVSize is not null)
            {
                IVSize = iVSize.Value;
            }

            if (pSubSampleMappingBlock is not null)
            {
                PSubSampleMappingBlock = pSubSampleMappingBlock;
            }

            if (subSampleMappingCount is not null)
            {
                SubSampleMappingCount = subSampleMappingCount.Value;
            }
        }


        [NativeName("Type", "D3D11_VIDEO_DECODER_BUFFER_TYPE")]
        [NativeName("Type.Name", "D3D11_VIDEO_DECODER_BUFFER_TYPE")]
        [NativeName("Name", "BufferType")]
        public VideoDecoderBufferType BufferType;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DataOffset")]
        public uint DataOffset;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DataSize")]
        public uint DataSize;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pIV")]
        public void* PIV;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "IVSize")]
        public uint IVSize;

        [NativeName("Type", "D3D11_VIDEO_DECODER_SUB_SAMPLE_MAPPING_BLOCK *")]
        [NativeName("Type.Name", "D3D11_VIDEO_DECODER_SUB_SAMPLE_MAPPING_BLOCK *")]
        [NativeName("Name", "pSubSampleMappingBlock")]
        public VideoDecoderSubSampleMappingBlock* PSubSampleMappingBlock;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SubSampleMappingCount")]
        public uint SubSampleMappingCount;
    }
}
