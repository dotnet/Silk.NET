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
    [NativeName("Name", "VkVideoEncodeH264NaluSliceEXT")]
    public unsafe partial struct VideoEncodeH264NaluSliceEXT : IChainable
    {
        public VideoEncodeH264NaluSliceEXT
        (
            StructureType? sType = StructureType.VideoEncodeH264NaluSliceExt,
            void* pNext = null,
            Video.StdVideoEncodeH264SliceHeader* pSliceHeaderStd = null,
            uint? mbCount = null,
            byte? refFinalList0EntryCount = null,
            VideoEncodeH264DpbSlotInfoEXT* pRefFinalList0Entries = null,
            byte? refFinalList1EntryCount = null,
            VideoEncodeH264DpbSlotInfoEXT* pRefFinalList1Entries = null
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

            if (pSliceHeaderStd is not null)
            {
                PSliceHeaderStd = pSliceHeaderStd;
            }

            if (mbCount is not null)
            {
                MbCount = mbCount.Value;
            }

            if (refFinalList0EntryCount is not null)
            {
                RefFinalList0EntryCount = refFinalList0EntryCount.Value;
            }

            if (pRefFinalList0Entries is not null)
            {
                PRefFinalList0Entries = pRefFinalList0Entries;
            }

            if (refFinalList1EntryCount is not null)
            {
                RefFinalList1EntryCount = refFinalList1EntryCount.Value;
            }

            if (pRefFinalList1Entries is not null)
            {
                PRefFinalList1Entries = pRefFinalList1Entries;
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
        [NativeName("Type", "StdVideoEncodeH264SliceHeader*")]
        [NativeName("Type.Name", "StdVideoEncodeH264SliceHeader")]
        [NativeName("Name", "pSliceHeaderStd")]
        public Video.StdVideoEncodeH264SliceHeader* PSliceHeaderStd;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "mbCount")]
        public uint MbCount;
/// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "refFinalList0EntryCount")]
        public byte RefFinalList0EntryCount;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH264DpbSlotInfoEXT*")]
        [NativeName("Type.Name", "VkVideoEncodeH264DpbSlotInfoEXT")]
        [NativeName("Name", "pRefFinalList0Entries")]
        public VideoEncodeH264DpbSlotInfoEXT* PRefFinalList0Entries;
/// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "refFinalList1EntryCount")]
        public byte RefFinalList1EntryCount;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH264DpbSlotInfoEXT*")]
        [NativeName("Type.Name", "VkVideoEncodeH264DpbSlotInfoEXT")]
        [NativeName("Name", "pRefFinalList1Entries")]
        public VideoEncodeH264DpbSlotInfoEXT* PRefFinalList1Entries;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH264NaluSliceExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
