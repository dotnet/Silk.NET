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
    [NativeName("Name", "VkVideoEncodeAV1DpbSlotInfoKHR")]
    public unsafe partial struct VideoEncodeAV1DpbSlotInfoKHR : IExtendsChain<VideoReferenceSlotInfoKHR>
    {
        public VideoEncodeAV1DpbSlotInfoKHR
        (
            StructureType? sType = StructureType.VideoEncodeAV1DpbSlotInfoKhr,
            void* pNext = null,
            Video.StdVideoEncodeAV1ReferenceInfo* pStdReferenceInfo = null
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

            if (pStdReferenceInfo is not null)
            {
                PStdReferenceInfo = pStdReferenceInfo;
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
        [NativeName("Type", "StdVideoEncodeAV1ReferenceInfo*")]
        [NativeName("Type.Name", "StdVideoEncodeAV1ReferenceInfo")]
        [NativeName("Name", "pStdReferenceInfo")]
        public Video.StdVideoEncodeAV1ReferenceInfo* PStdReferenceInfo;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeAV1DpbSlotInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
