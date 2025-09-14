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
    [NativeName("Name", "VkVideoDecodeVP9PictureInfoKHR")]
    public unsafe partial struct VideoDecodeVP9PictureInfoKHR : IExtendsChain<VideoDecodeInfoKHR>
    {
        public VideoDecodeVP9PictureInfoKHR
        (
            StructureType? sType = StructureType.VideoDecodeVP9PictureInfoKhr,
            void* pNext = null,
            StdVideoDecodeVP9PictureInfo* pStdPictureInfo = null,
            uint? uncompressedHeaderOffset = null,
            uint? compressedHeaderOffset = null,
            uint? tilesOffset = null
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

            if (uncompressedHeaderOffset is not null)
            {
                UncompressedHeaderOffset = uncompressedHeaderOffset.Value;
            }

            if (compressedHeaderOffset is not null)
            {
                CompressedHeaderOffset = compressedHeaderOffset.Value;
            }

            if (tilesOffset is not null)
            {
                TilesOffset = tilesOffset.Value;
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
        [NativeName("Type", "StdVideoDecodeVP9PictureInfo*")]
        [NativeName("Type.Name", "StdVideoDecodeVP9PictureInfo")]
        [NativeName("Name", "pStdPictureInfo")]
        public StdVideoDecodeVP9PictureInfo* PStdPictureInfo;
        /// <summary></summary>
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "referenceNameSlotIndices")]
        public fixed int ReferenceNameSlotIndices[3];
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "uncompressedHeaderOffset")]
        public uint UncompressedHeaderOffset;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "compressedHeaderOffset")]
        public uint CompressedHeaderOffset;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "tilesOffset")]
        public uint TilesOffset;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoDecodeVP9PictureInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
