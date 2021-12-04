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
    [NativeName("Name", "VkVideoEncodeRateControlLayerInfoKHR")]
    public unsafe partial struct VideoEncodeRateControlLayerInfoKHR : IChainStart, IExtendsChain<VideoCodingControlInfoKHR>
    {
        public VideoEncodeRateControlLayerInfoKHR
        (
            StructureType? sType = StructureType.VideoEncodeRateControlLayerInfoKhr,
            void* pNext = null,
            uint? averageBitrate = null,
            uint? maxBitrate = null,
            uint? frameRateNumerator = null,
            uint? frameRateDenominator = null,
            uint? virtualBufferSizeInMs = null,
            uint? initialVirtualBufferSizeInMs = null
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

            if (averageBitrate is not null)
            {
                AverageBitrate = averageBitrate.Value;
            }

            if (maxBitrate is not null)
            {
                MaxBitrate = maxBitrate.Value;
            }

            if (frameRateNumerator is not null)
            {
                FrameRateNumerator = frameRateNumerator.Value;
            }

            if (frameRateDenominator is not null)
            {
                FrameRateDenominator = frameRateDenominator.Value;
            }

            if (virtualBufferSizeInMs is not null)
            {
                VirtualBufferSizeInMs = virtualBufferSizeInMs.Value;
            }

            if (initialVirtualBufferSizeInMs is not null)
            {
                InitialVirtualBufferSizeInMs = initialVirtualBufferSizeInMs.Value;
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
        [NativeName("Name", "averageBitrate")]
        public uint AverageBitrate;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxBitrate")]
        public uint MaxBitrate;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "frameRateNumerator")]
        public uint FrameRateNumerator;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "frameRateDenominator")]
        public uint FrameRateDenominator;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "virtualBufferSizeInMs")]
        public uint VirtualBufferSizeInMs;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "initialVirtualBufferSizeInMs")]
        public uint InitialVirtualBufferSizeInMs;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeRateControlLayerInfoKhr;
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
        public static unsafe ref VideoEncodeRateControlLayerInfoKHR Chain(
            out VideoEncodeRateControlLayerInfoKHR capture)
        {
            capture = new VideoEncodeRateControlLayerInfoKHR(StructureType.VideoEncodeRateControlLayerInfoKhr);
            return ref capture;
        }
    }
}
