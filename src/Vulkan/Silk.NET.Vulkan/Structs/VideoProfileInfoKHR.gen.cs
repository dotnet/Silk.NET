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
    [NativeName("Name", "VkVideoProfileInfoKHR")]
    public unsafe partial struct VideoProfileInfoKHR : IChainStart, IExtendsChain<QueryPoolCreateInfo>
    {
        public VideoProfileInfoKHR
        (
            StructureType? sType = StructureType.VideoProfileInfoKhr,
            void* pNext = null,
            VideoCodecOperationFlagsKHR? videoCodecOperation = null,
            VideoChromaSubsamplingFlagsKHR? chromaSubsampling = null,
            VideoComponentBitDepthFlagsKHR? lumaBitDepth = null,
            VideoComponentBitDepthFlagsKHR? chromaBitDepth = null
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

            if (videoCodecOperation is not null)
            {
                VideoCodecOperation = videoCodecOperation.Value;
            }

            if (chromaSubsampling is not null)
            {
                ChromaSubsampling = chromaSubsampling.Value;
            }

            if (lumaBitDepth is not null)
            {
                LumaBitDepth = lumaBitDepth.Value;
            }

            if (chromaBitDepth is not null)
            {
                ChromaBitDepth = chromaBitDepth.Value;
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
        [NativeName("Type", "VkVideoCodecOperationFlagBitsKHR")]
        [NativeName("Type.Name", "VkVideoCodecOperationFlagBitsKHR")]
        [NativeName("Name", "videoCodecOperation")]
        public VideoCodecOperationFlagsKHR VideoCodecOperation;
/// <summary></summary>
        [NativeName("Type", "VkVideoChromaSubsamplingFlagsKHR")]
        [NativeName("Type.Name", "VkVideoChromaSubsamplingFlagsKHR")]
        [NativeName("Name", "chromaSubsampling")]
        public VideoChromaSubsamplingFlagsKHR ChromaSubsampling;
/// <summary></summary>
        [NativeName("Type", "VkVideoComponentBitDepthFlagsKHR")]
        [NativeName("Type.Name", "VkVideoComponentBitDepthFlagsKHR")]
        [NativeName("Name", "lumaBitDepth")]
        public VideoComponentBitDepthFlagsKHR LumaBitDepth;
/// <summary></summary>
        [NativeName("Type", "VkVideoComponentBitDepthFlagsKHR")]
        [NativeName("Type.Name", "VkVideoComponentBitDepthFlagsKHR")]
        [NativeName("Name", "chromaBitDepth")]
        public VideoComponentBitDepthFlagsKHR ChromaBitDepth;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoProfileInfoKhr;
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
        public static unsafe ref VideoProfileInfoKHR Chain(
            out VideoProfileInfoKHR capture)
        {
            capture = new VideoProfileInfoKHR(StructureType.VideoProfileInfoKhr);
            return ref capture;
        }
    }
}
