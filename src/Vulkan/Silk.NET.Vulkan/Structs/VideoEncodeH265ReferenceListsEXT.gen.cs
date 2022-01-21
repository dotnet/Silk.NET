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
    [NativeName("Name", "VkVideoEncodeH265ReferenceListsEXT")]
    public unsafe partial struct VideoEncodeH265ReferenceListsEXT : IChainable
    {
        public VideoEncodeH265ReferenceListsEXT
        (
            StructureType? sType = StructureType.VideoEncodeH265ReferenceListsExt,
            void* pNext = null,
            byte? referenceList0EntryCount = null,
            VideoEncodeH265DpbSlotInfoEXT* pReferenceList0Entries = null,
            byte? referenceList1EntryCount = null,
            VideoEncodeH265DpbSlotInfoEXT* pReferenceList1Entries = null,
            Video.StdVideoEncodeH265ReferenceModifications* pReferenceModifications = null
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

            if (pReferenceModifications is not null)
            {
                PReferenceModifications = pReferenceModifications;
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
        [NativeName("Type", "VkVideoEncodeH265DpbSlotInfoEXT*")]
        [NativeName("Type.Name", "VkVideoEncodeH265DpbSlotInfoEXT")]
        [NativeName("Name", "pReferenceList0Entries")]
        public VideoEncodeH265DpbSlotInfoEXT* PReferenceList0Entries;
/// <summary></summary>
        [NativeName("Type", "uint8_t")]
        [NativeName("Type.Name", "uint8_t")]
        [NativeName("Name", "referenceList1EntryCount")]
        public byte ReferenceList1EntryCount;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH265DpbSlotInfoEXT*")]
        [NativeName("Type.Name", "VkVideoEncodeH265DpbSlotInfoEXT")]
        [NativeName("Name", "pReferenceList1Entries")]
        public VideoEncodeH265DpbSlotInfoEXT* PReferenceList1Entries;
/// <summary></summary>
        [NativeName("Type", "StdVideoEncodeH265ReferenceModifications*")]
        [NativeName("Type.Name", "StdVideoEncodeH265ReferenceModifications")]
        [NativeName("Name", "pReferenceModifications")]
        public Video.StdVideoEncodeH265ReferenceModifications* PReferenceModifications;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH265ReferenceListsExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
