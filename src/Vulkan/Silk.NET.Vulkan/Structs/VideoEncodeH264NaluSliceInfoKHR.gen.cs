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
    [NativeName("Name", "VkVideoEncodeH264NaluSliceInfoKHR")]
    public unsafe partial struct VideoEncodeH264NaluSliceInfoKHR : IChainable
    {
        public VideoEncodeH264NaluSliceInfoKHR
        (
            StructureType? sType = StructureType.VideoEncodeH264NaluSliceInfoKhr,
            void* pNext = null,
            int? constantQp = null,
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

            if (constantQp is not null)
            {
                ConstantQp = constantQp.Value;
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
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "constantQp")]
        public int ConstantQp;
/// <summary></summary>
        [NativeName("Type", "StdVideoEncodeH264SliceHeader*")]
        [NativeName("Type.Name", "StdVideoEncodeH264SliceHeader")]
        [NativeName("Name", "pStdSliceHeader")]
        public Video.StdVideoEncodeH264SliceHeader* PStdSliceHeader;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH264NaluSliceInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
