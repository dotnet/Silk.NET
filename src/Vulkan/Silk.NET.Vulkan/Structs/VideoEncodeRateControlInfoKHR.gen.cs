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
    [NativeName("Name", "VkVideoEncodeRateControlInfoKHR")]
    public unsafe partial struct VideoEncodeRateControlInfoKHR : IExtendsChain<VideoCodingControlInfoKHR>
    {
        public VideoEncodeRateControlInfoKHR
        (
            StructureType? sType = StructureType.VideoEncodeRateControlInfoKhr,
            void* pNext = null,
            VideoEncodeRateControlFlagsKHR? flags = null,
            VideoEncodeRateControlModeFlagsKHR? rateControlMode = null,
            uint? averageBitrate = null,
            ushort? peakToAverageBitrateRatio = null,
            ushort? frameRateNumerator = null,
            ushort? frameRateDenominator = null,
            uint? virtualBufferSizeInMs = null
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

            if (rateControlMode is not null)
            {
                RateControlMode = rateControlMode.Value;
            }

            if (averageBitrate is not null)
            {
                AverageBitrate = averageBitrate.Value;
            }

            if (peakToAverageBitrateRatio is not null)
            {
                PeakToAverageBitrateRatio = peakToAverageBitrateRatio.Value;
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
        [NativeName("Type", "VkVideoEncodeRateControlFlagsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeRateControlFlagsKHR")]
        [NativeName("Name", "flags")]
        public VideoEncodeRateControlFlagsKHR Flags;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeRateControlModeFlagBitsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeRateControlModeFlagBitsKHR")]
        [NativeName("Name", "rateControlMode")]
        public VideoEncodeRateControlModeFlagsKHR RateControlMode;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "averageBitrate")]
        public uint AverageBitrate;
/// <summary></summary>
        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "peakToAverageBitrateRatio")]
        public ushort PeakToAverageBitrateRatio;
/// <summary></summary>
        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "frameRateNumerator")]
        public ushort FrameRateNumerator;
/// <summary></summary>
        [NativeName("Type", "uint16_t")]
        [NativeName("Type.Name", "uint16_t")]
        [NativeName("Name", "frameRateDenominator")]
        public ushort FrameRateDenominator;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "virtualBufferSizeInMs")]
        public uint VirtualBufferSizeInMs;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeRateControlInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
