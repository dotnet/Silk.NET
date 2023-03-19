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
    [NativeName("Name", "VkVideoEncodeH265VclFrameInfoEXT")]
    public unsafe partial struct VideoEncodeH265VclFrameInfoEXT : IExtendsChain<VideoEncodeInfoKHR>
    {
        public VideoEncodeH265VclFrameInfoEXT
        (
            StructureType? sType = StructureType.VideoEncodeH265VclFrameInfoExt,
            void* pNext = null,
            Video.StdVideoEncodeH265ReferenceListsInfo* pStdReferenceFinalLists = null,
            uint? naluSliceSegmentEntryCount = null,
            VideoEncodeH265NaluSliceSegmentInfoEXT* pNaluSliceSegmentEntries = null,
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

            if (pStdReferenceFinalLists is not null)
            {
                PStdReferenceFinalLists = pStdReferenceFinalLists;
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
        [NativeName("Type", "StdVideoEncodeH265ReferenceListsInfo*")]
        [NativeName("Type.Name", "StdVideoEncodeH265ReferenceListsInfo")]
        [NativeName("Name", "pStdReferenceFinalLists")]
        public Video.StdVideoEncodeH265ReferenceListsInfo* PStdReferenceFinalLists;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "naluSliceSegmentEntryCount")]
        public uint NaluSliceSegmentEntryCount;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH265NaluSliceSegmentInfoEXT*")]
        [NativeName("Type.Name", "VkVideoEncodeH265NaluSliceSegmentInfoEXT")]
        [NativeName("Name", "pNaluSliceSegmentEntries")]
        public VideoEncodeH265NaluSliceSegmentInfoEXT* PNaluSliceSegmentEntries;
/// <summary></summary>
        [NativeName("Type", "StdVideoEncodeH265PictureInfo*")]
        [NativeName("Type.Name", "StdVideoEncodeH265PictureInfo")]
        [NativeName("Name", "pStdPictureInfo")]
        public Video.StdVideoEncodeH265PictureInfo* PStdPictureInfo;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH265VclFrameInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
