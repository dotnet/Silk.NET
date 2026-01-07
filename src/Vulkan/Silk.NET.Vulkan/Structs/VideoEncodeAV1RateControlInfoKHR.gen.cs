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
    [NativeName("Name", "VkVideoEncodeAV1RateControlInfoKHR")]
    public unsafe partial struct VideoEncodeAV1RateControlInfoKHR : IExtendsChain<VideoCodingControlInfoKHR>, IExtendsChain<VideoBeginCodingInfoKHR>
    {
        public VideoEncodeAV1RateControlInfoKHR
        (
            StructureType? sType = StructureType.VideoEncodeAV1RateControlInfoKhr,
            void* pNext = null,
            VideoEncodeAV1RateControlFlagsKHR? flags = null,
            uint? gopFrameCount = null,
            uint? keyFramePeriod = null,
            uint? consecutiveBipredictiveFrameCount = null,
            uint? temporalLayerCount = null
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

            if (gopFrameCount is not null)
            {
                GopFrameCount = gopFrameCount.Value;
            }

            if (keyFramePeriod is not null)
            {
                KeyFramePeriod = keyFramePeriod.Value;
            }

            if (consecutiveBipredictiveFrameCount is not null)
            {
                ConsecutiveBipredictiveFrameCount = consecutiveBipredictiveFrameCount.Value;
            }

            if (temporalLayerCount is not null)
            {
                TemporalLayerCount = temporalLayerCount.Value;
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
        [NativeName("Type", "VkVideoEncodeAV1RateControlFlagsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeAV1RateControlFlagsKHR")]
        [NativeName("Name", "flags")]
        public VideoEncodeAV1RateControlFlagsKHR Flags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "gopFrameCount")]
        public uint GopFrameCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "keyFramePeriod")]
        public uint KeyFramePeriod;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "consecutiveBipredictiveFrameCount")]
        public uint ConsecutiveBipredictiveFrameCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "temporalLayerCount")]
        public uint TemporalLayerCount;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeAV1RateControlInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
