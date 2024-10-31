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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkVideoDecodeAV1PictureInfoKHR")]
    public unsafe partial struct VideoDecodeAV1PictureInfoKHR : IExtendsChain<VideoDecodeInfoKHR>
    {
        public VideoDecodeAV1PictureInfoKHR
        (
            StructureType? sType = StructureType.VideoDecodeAV1PictureInfoKhr,
            void* pNext = null,
            Video.StdVideoDecodeAV1PictureInfo* pStdPictureInfo = null,
            uint? frameHeaderOffset = null,
            uint? tileCount = null,
            uint* pTileOffsets = null,
            uint* pTileSizes = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (pStdPictureInfo is not null)
            {
                PStdPictureInfo = pStdPictureInfo;
            }

            if (frameHeaderOffset is not null)
            {
                FrameHeaderOffset = frameHeaderOffset.Value;
            }

            if (tileCount is not null)
            {
                TileCount = tileCount.Value;
            }

            if (pTileOffsets is not null)
            {
                PTileOffsets = pTileOffsets;
            }

            if (pTileSizes is not null)
            {
                PTileSizes = pTileSizes;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "StdVideoDecodeAV1PictureInfo*")]
        [NativeName("Type.Name", "StdVideoDecodeAV1PictureInfo")]
        [NativeName("Name", "pStdPictureInfo")]
        public Video.StdVideoDecodeAV1PictureInfo* PStdPictureInfo;
        /// <summary></summary>
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "referenceNameSlotIndices")]
        public fixed int ReferenceNameSlotIndices[7];
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "frameHeaderOffset")]
        public uint FrameHeaderOffset;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "tileCount")]
        public uint TileCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pTileOffsets")]
        public uint* PTileOffsets;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pTileSizes")]
        public uint* PTileSizes;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoDecodeAV1PictureInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
