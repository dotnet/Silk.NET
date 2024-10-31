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
    [NativeName("Name", "VkVideoEncodeH265PictureInfoKHR")]
    public unsafe partial struct VideoEncodeH265PictureInfoKHR : IExtendsChain<VideoEncodeInfoKHR>
    {
        public VideoEncodeH265PictureInfoKHR
        (
            StructureType? sType = StructureType.VideoEncodeH265PictureInfoKhr,
            void* pNext = null,
            uint? naluSliceSegmentEntryCount = null,
            VideoEncodeH265NaluSliceSegmentInfoKHR* pNaluSliceSegmentEntries = null,
            Video.StdVideoEncodeH265PictureInfo* pStdPictureInfo = null
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

            if (naluSliceSegmentEntryCount is not null)
            {
                NaluSliceSegmentEntryCount = naluSliceSegmentEntryCount.Value;
            }

            if (pNaluSliceSegmentEntries is not null)
            {
                PNaluSliceSegmentEntries = pNaluSliceSegmentEntries;
            }

            if (pStdPictureInfo is not null)
            {
                PStdPictureInfo = pStdPictureInfo;
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
        [NativeName("Name", "naluSliceSegmentEntryCount")]
        public uint NaluSliceSegmentEntryCount;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH265NaluSliceSegmentInfoKHR*")]
        [NativeName("Type.Name", "VkVideoEncodeH265NaluSliceSegmentInfoKHR")]
        [NativeName("Name", "pNaluSliceSegmentEntries")]
        public VideoEncodeH265NaluSliceSegmentInfoKHR* PNaluSliceSegmentEntries;
/// <summary></summary>
        [NativeName("Type", "StdVideoEncodeH265PictureInfo*")]
        [NativeName("Type.Name", "StdVideoEncodeH265PictureInfo")]
        [NativeName("Name", "pStdPictureInfo")]
        public Video.StdVideoEncodeH265PictureInfo* PStdPictureInfo;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH265PictureInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
