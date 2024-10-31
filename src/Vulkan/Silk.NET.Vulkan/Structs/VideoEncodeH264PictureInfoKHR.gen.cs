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
    [NativeName("Name", "VkVideoEncodeH264PictureInfoKHR")]
    public unsafe partial struct VideoEncodeH264PictureInfoKHR : IExtendsChain<VideoEncodeInfoKHR>
    {
        public VideoEncodeH264PictureInfoKHR
        (
            StructureType? sType = StructureType.VideoEncodeH264PictureInfoKhr,
            void* pNext = null,
            uint? naluSliceEntryCount = null,
            VideoEncodeH264NaluSliceInfoKHR* pNaluSliceEntries = null,
            Video.StdVideoEncodeH264PictureInfo* pStdPictureInfo = null,
            Bool32? generatePrefixNalu = null
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

            if (naluSliceEntryCount is not null)
            {
                NaluSliceEntryCount = naluSliceEntryCount.Value;
            }

            if (pNaluSliceEntries is not null)
            {
                PNaluSliceEntries = pNaluSliceEntries;
            }

            if (pStdPictureInfo is not null)
            {
                PStdPictureInfo = pStdPictureInfo;
            }

            if (generatePrefixNalu is not null)
            {
                GeneratePrefixNalu = generatePrefixNalu.Value;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "naluSliceEntryCount")]
        public uint NaluSliceEntryCount;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH264NaluSliceInfoKHR*")]
        [NativeName("Type.Name", "VkVideoEncodeH264NaluSliceInfoKHR")]
        [NativeName("Name", "pNaluSliceEntries")]
        public VideoEncodeH264NaluSliceInfoKHR* PNaluSliceEntries;
/// <summary></summary>
        [NativeName("Type", "StdVideoEncodeH264PictureInfo*")]
        [NativeName("Type.Name", "StdVideoEncodeH264PictureInfo")]
        [NativeName("Name", "pStdPictureInfo")]
        public Video.StdVideoEncodeH264PictureInfo* PStdPictureInfo;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "generatePrefixNalu")]
        public Bool32 GeneratePrefixNalu;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH264PictureInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
