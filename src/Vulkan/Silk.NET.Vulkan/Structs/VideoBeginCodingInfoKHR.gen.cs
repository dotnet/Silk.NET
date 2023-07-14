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
    [NativeName("Name", "VkVideoBeginCodingInfoKHR")]
    public unsafe partial struct VideoBeginCodingInfoKHR : IChainStart
    {
        public VideoBeginCodingInfoKHR
        (
            StructureType? sType = StructureType.VideoBeginCodingInfoKhr,
            void* pNext = null,
            uint? flags = null,
            VideoSessionKHR? videoSession = null,
            VideoSessionParametersKHR? videoSessionParameters = null,
            uint? referenceSlotCount = null,
            VideoReferenceSlotInfoKHR* pReferenceSlots = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (videoSession is not null)
            {
                VideoSession = videoSession.Value;
            }

            if (videoSessionParameters is not null)
            {
                VideoSessionParameters = videoSessionParameters.Value;
            }

            if (referenceSlotCount is not null)
            {
                ReferenceSlotCount = referenceSlotCount.Value;
            }

            if (pReferenceSlots is not null)
            {
                PReferenceSlots = pReferenceSlots;
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
        [NativeName("Type", "VkVideoBeginCodingFlagsKHR")]
        [NativeName("Type.Name", "VkVideoBeginCodingFlagsKHR")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkVideoSessionKHR")]
        [NativeName("Type.Name", "VkVideoSessionKHR")]
        [NativeName("Name", "videoSession")]
        public VideoSessionKHR VideoSession;
/// <summary></summary>
        [NativeName("Type", "VkVideoSessionParametersKHR")]
        [NativeName("Type.Name", "VkVideoSessionParametersKHR")]
        [NativeName("Name", "videoSessionParameters")]
        public VideoSessionParametersKHR VideoSessionParameters;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "referenceSlotCount")]
        public uint ReferenceSlotCount;
/// <summary></summary>
        [NativeName("Type", "VkVideoReferenceSlotInfoKHR*")]
        [NativeName("Type.Name", "VkVideoReferenceSlotInfoKHR")]
        [NativeName("Name", "pReferenceSlots")]
        public VideoReferenceSlotInfoKHR* PReferenceSlots;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoBeginCodingInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref VideoBeginCodingInfoKHR Chain(
            out VideoBeginCodingInfoKHR capture)
        {
            capture = new VideoBeginCodingInfoKHR(StructureType.VideoBeginCodingInfoKhr);
            return ref capture;
        }
    }
}
