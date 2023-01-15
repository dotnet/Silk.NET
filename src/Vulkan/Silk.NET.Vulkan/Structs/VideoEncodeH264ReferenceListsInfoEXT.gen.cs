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
    [NativeName("Name", "VkVideoEncodeH264ReferenceListsInfoEXT")]
    public unsafe partial struct VideoEncodeH264ReferenceListsInfoEXT : IChainable
    {
        public VideoEncodeH264ReferenceListsInfoEXT
        (
            StructureType? sType = StructureType.VideoEncodeH264ReferenceListsInfoExt,
            void* pNext = null,
            byte? referenceList0EntryCount = null,
            VideoEncodeH264DpbSlotInfoEXT* pReferenceList0Entries = null,
            byte? referenceList1EntryCount = null,
            VideoEncodeH264DpbSlotInfoEXT* pReferenceList1Entries = null,
            Video.StdVideoEncodeH264RefMemMgmtCtrlOperations* pMemMgmtCtrlOperations = null
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

            if (referenceList0EntryCount is not null)
            {
                ReferenceList0EntryCount = referenceList0EntryCount.Value;
            }

            if (pReferenceList0Entries is not null)
            {
                PReferenceList0Entries = pReferenceList0Entries;
            }

            if (referenceList1EntryCount is not null)
            {
                ReferenceList1EntryCount = referenceList1EntryCount.Value;
            }

            if (pReferenceList1Entries is not null)
            {
                PReferenceList1Entries = pReferenceList1Entries;
            }

            if (pMemMgmtCtrlOperations is not null)
            {
                PMemMgmtCtrlOperations = pMemMgmtCtrlOperations;
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
        [NativeName("Name", "referenceList0EntryCount")]
        public byte ReferenceList0EntryCount;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH264DpbSlotInfoEXT*")]
        [NativeName("Type.Name", "VkVideoEncodeH264DpbSlotInfoEXT")]
        [NativeName("Name", "pReferenceList0Entries")]
        public VideoEncodeH264DpbSlotInfoEXT* PReferenceList0Entries;
/// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "referenceList1EntryCount")]
        public byte ReferenceList1EntryCount;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH264DpbSlotInfoEXT*")]
        [NativeName("Type.Name", "VkVideoEncodeH264DpbSlotInfoEXT")]
        [NativeName("Name", "pReferenceList1Entries")]
        public VideoEncodeH264DpbSlotInfoEXT* PReferenceList1Entries;
/// <summary></summary>
        [NativeName("Type", "StdVideoEncodeH264RefMemMgmtCtrlOperations*")]
        [NativeName("Type.Name", "StdVideoEncodeH264RefMemMgmtCtrlOperations")]
        [NativeName("Name", "pMemMgmtCtrlOperations")]
        public Video.StdVideoEncodeH264RefMemMgmtCtrlOperations* PMemMgmtCtrlOperations;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH264ReferenceListsInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
