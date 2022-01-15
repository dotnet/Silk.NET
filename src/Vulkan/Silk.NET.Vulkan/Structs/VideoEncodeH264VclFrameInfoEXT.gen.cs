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
            byte? refDefaultFinalList0EntryCount = null,
            VideoEncodeH264DpbSlotInfoEXT* pRefDefaultFinalList0Entries = null,
            byte? refDefaultFinalList1EntryCount = null,
            VideoEncodeH264DpbSlotInfoEXT* pRefDefaultFinalList1Entries = null,
            uint? naluSliceEntryCount = null,
            VideoEncodeH264NaluSliceEXT* pNaluSliceEntries = null,
            VideoEncodeH264DpbSlotInfoEXT* pCurrentPictureInfo = null
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

            if (refDefaultFinalList0EntryCount is not null)
            {
                RefDefaultFinalList0EntryCount = refDefaultFinalList0EntryCount.Value;
            }

            if (pRefDefaultFinalList0Entries is not null)
            {
                PRefDefaultFinalList0Entries = pRefDefaultFinalList0Entries;
            }

            if (refDefaultFinalList1EntryCount is not null)
            {
                RefDefaultFinalList1EntryCount = refDefaultFinalList1EntryCount.Value;
            }

            if (pRefDefaultFinalList1Entries is not null)
            {
                PRefDefaultFinalList1Entries = pRefDefaultFinalList1Entries;
            }

            if (naluSliceEntryCount is not null)
            {
                NaluSliceEntryCount = naluSliceEntryCount.Value;
            }

            if (pNaluSliceEntries is not null)
            {
                PNaluSliceEntries = pNaluSliceEntries;
            }

            if (pCurrentPictureInfo is not null)
            {
                PCurrentPictureInfo = pCurrentPictureInfo;
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
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "refDefaultFinalList0EntryCount")]
        public byte RefDefaultFinalList0EntryCount;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH264DpbSlotInfoEXT*")]
        [NativeName("Type.Name", "VkVideoEncodeH264DpbSlotInfoEXT")]
        [NativeName("Name", "pRefDefaultFinalList0Entries")]
        public VideoEncodeH264DpbSlotInfoEXT* PRefDefaultFinalList0Entries;
/// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "refDefaultFinalList1EntryCount")]
        public byte RefDefaultFinalList1EntryCount;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH264DpbSlotInfoEXT*")]
        [NativeName("Type.Name", "VkVideoEncodeH264DpbSlotInfoEXT")]
        [NativeName("Name", "pRefDefaultFinalList1Entries")]
        public VideoEncodeH264DpbSlotInfoEXT* PRefDefaultFinalList1Entries;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "naluSliceEntryCount")]
        public uint NaluSliceEntryCount;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH264NaluSliceEXT*")]
        [NativeName("Type.Name", "VkVideoEncodeH264NaluSliceEXT")]
        [NativeName("Name", "pNaluSliceEntries")]
        public VideoEncodeH264NaluSliceEXT* PNaluSliceEntries;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH264DpbSlotInfoEXT*")]
        [NativeName("Type.Name", "VkVideoEncodeH264DpbSlotInfoEXT")]
        [NativeName("Name", "pCurrentPictureInfo")]
        public VideoEncodeH264DpbSlotInfoEXT* PCurrentPictureInfo;

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
