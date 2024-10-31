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
    [NativeName("Name", "VkVideoDecodeAV1DpbSlotInfoKHR")]
    public unsafe partial struct VideoDecodeAV1DpbSlotInfoKHR : IExtendsChain<VideoReferenceSlotInfoKHR>
    {
        public VideoDecodeAV1DpbSlotInfoKHR
        (
            StructureType? sType = StructureType.VideoDecodeAV1DpbSlotInfoKhr,
            void* pNext = null,
            Video.StdVideoDecodeAV1ReferenceInfo* pStdReferenceInfo = null
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
        [NativeName("Type", "StdVideoDecodeAV1ReferenceInfo*")]
        [NativeName("Type.Name", "StdVideoDecodeAV1ReferenceInfo")]
        [NativeName("Name", "pStdReferenceInfo")]
        public Video.StdVideoDecodeAV1ReferenceInfo* PStdReferenceInfo;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoDecodeAV1DpbSlotInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
