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
    [NativeName("Name", "VkVideoEncodeH265NaluSliceEXT")]
    public unsafe partial struct VideoEncodeH265NaluSliceEXT : IChainable
    {
        public VideoEncodeH265NaluSliceEXT
        (
            StructureType? sType = StructureType.VideoEncodeH265NaluSliceExt,
            void* pNext = null,
            uint? ctbCount = null,
            VideoEncodeH265ReferenceListsEXT* pReferenceFinalLists = null,
            Video.StdVideoEncodeH265SliceHeader* pSliceHeaderStd = null
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

            if (ctbCount is not null)
            {
                CtbCount = ctbCount.Value;
            }

            if (pReferenceFinalLists is not null)
            {
                PReferenceFinalLists = pReferenceFinalLists;
            }

            if (pSliceHeaderStd is not null)
            {
                PSliceHeaderStd = pSliceHeaderStd;
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
        [NativeName("Name", "ctbCount")]
        public uint CtbCount;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH265ReferenceListsEXT*")]
        [NativeName("Type.Name", "VkVideoEncodeH265ReferenceListsEXT")]
        [NativeName("Name", "pReferenceFinalLists")]
        public VideoEncodeH265ReferenceListsEXT* PReferenceFinalLists;
/// <summary></summary>
        [NativeName("Type", "StdVideoEncodeH265SliceHeader*")]
        [NativeName("Type.Name", "StdVideoEncodeH265SliceHeader")]
        [NativeName("Name", "pSliceHeaderStd")]
        public Video.StdVideoEncodeH265SliceHeader* PSliceHeaderStd;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH265NaluSliceExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
