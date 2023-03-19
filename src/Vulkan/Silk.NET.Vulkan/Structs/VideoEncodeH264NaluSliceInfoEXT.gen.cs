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
    [NativeName("Name", "VkVideoEncodeH264NaluSliceInfoEXT")]
    public unsafe partial struct VideoEncodeH264NaluSliceInfoEXT : IChainable
    {
        public VideoEncodeH264NaluSliceInfoEXT
        (
            StructureType? sType = StructureType.VideoEncodeH264NaluSliceInfoExt,
            void* pNext = null,
            uint? mbCount = null,
            Video.StdVideoEncodeH264ReferenceListsInfo* pStdReferenceFinalLists = null,
            Video.StdVideoEncodeH264SliceHeader* pStdSliceHeader = null
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

            if (mbCount is not null)
            {
                MbCount = mbCount.Value;
            }

            if (pStdReferenceFinalLists is not null)
            {
                PStdReferenceFinalLists = pStdReferenceFinalLists;
            }

            if (pStdSliceHeader is not null)
            {
                PStdSliceHeader = pStdSliceHeader;
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
        [NativeName("Name", "mbCount")]
        public uint MbCount;
/// <summary></summary>
        [NativeName("Type", "StdVideoEncodeH264ReferenceListsInfo*")]
        [NativeName("Type.Name", "StdVideoEncodeH264ReferenceListsInfo")]
        [NativeName("Name", "pStdReferenceFinalLists")]
        public Video.StdVideoEncodeH264ReferenceListsInfo* PStdReferenceFinalLists;
/// <summary></summary>
        [NativeName("Type", "StdVideoEncodeH264SliceHeader*")]
        [NativeName("Type.Name", "StdVideoEncodeH264SliceHeader")]
        [NativeName("Name", "pStdSliceHeader")]
        public Video.StdVideoEncodeH264SliceHeader* PStdSliceHeader;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH264NaluSliceInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
