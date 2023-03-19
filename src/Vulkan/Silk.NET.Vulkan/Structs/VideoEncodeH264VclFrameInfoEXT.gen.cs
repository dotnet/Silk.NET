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
    [NativeName("Name", "VkVideoEncodeH264VclFrameInfoEXT")]
    public unsafe partial struct VideoEncodeH264VclFrameInfoEXT : IExtendsChain<VideoEncodeInfoKHR>
    {
        public VideoEncodeH264VclFrameInfoEXT
        (
            StructureType? sType = StructureType.VideoEncodeH264VclFrameInfoExt,
            void* pNext = null,
            StdVideoEncodeH264ReferenceListsInfo* pStdReferenceFinalLists = null,
            uint? naluSliceEntryCount = null,
            VideoEncodeH264NaluSliceInfoEXT* pNaluSliceEntries = null,
            Video.StdVideoEncodeH264PictureInfo* pStdPictureInfo = null
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
        [NativeName("Type", "StdVideoEncodeH264ReferenceListsInfo*")]
        [NativeName("Type.Name", "StdVideoEncodeH264ReferenceListsInfo")]
        [NativeName("Name", "pStdReferenceFinalLists")]
        public StdVideoEncodeH264ReferenceListsInfo* PStdReferenceFinalLists;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "naluSliceEntryCount")]
        public uint NaluSliceEntryCount;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH264NaluSliceInfoEXT*")]
        [NativeName("Type.Name", "VkVideoEncodeH264NaluSliceInfoEXT")]
        [NativeName("Name", "pNaluSliceEntries")]
        public VideoEncodeH264NaluSliceInfoEXT* PNaluSliceEntries;
/// <summary></summary>
        [NativeName("Type", "StdVideoEncodeH264PictureInfo*")]
        [NativeName("Type.Name", "StdVideoEncodeH264PictureInfo")]
        [NativeName("Name", "pStdPictureInfo")]
        public Video.StdVideoEncodeH264PictureInfo* PStdPictureInfo;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH264VclFrameInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
