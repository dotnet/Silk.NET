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
    [NativeName("Name", "VkVideoEncodeH265NaluSliceSegmentInfoKHR")]
    public unsafe partial struct VideoEncodeH265NaluSliceSegmentInfoKHR : IChainable
    {
        public VideoEncodeH265NaluSliceSegmentInfoKHR
        (
            StructureType? sType = StructureType.VideoEncodeH265NaluSliceSegmentInfoKhr,
            void* pNext = null,
            int? constantQp = null,
            Video.StdVideoEncodeH265SliceSegmentHeader* pStdSliceSegmentHeader = null
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

            if (constantQp is not null)
            {
                ConstantQp = constantQp.Value;
            }

            if (pStdSliceSegmentHeader is not null)
            {
                PStdSliceSegmentHeader = pStdSliceSegmentHeader;
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
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "constantQp")]
        public int ConstantQp;
/// <summary></summary>
        [NativeName("Type", "StdVideoEncodeH265SliceSegmentHeader*")]
        [NativeName("Type.Name", "StdVideoEncodeH265SliceSegmentHeader")]
        [NativeName("Name", "pStdSliceSegmentHeader")]
        public Video.StdVideoEncodeH265SliceSegmentHeader* PStdSliceSegmentHeader;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH265NaluSliceSegmentInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
