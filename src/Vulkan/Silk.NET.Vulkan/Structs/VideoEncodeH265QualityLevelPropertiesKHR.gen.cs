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
    [NativeName("Name", "VkVideoEncodeH265QualityLevelPropertiesKHR")]
    public unsafe partial struct VideoEncodeH265QualityLevelPropertiesKHR : IExtendsChain<VideoEncodeQualityLevelPropertiesKHR>
    {
        public VideoEncodeH265QualityLevelPropertiesKHR
        (
            StructureType? sType = StructureType.VideoEncodeH265QualityLevelPropertiesKhr,
            void* pNext = null,
            VideoEncodeH265RateControlFlagsKHR? preferredRateControlFlags = null,
            uint? preferredGopFrameCount = null,
            uint? preferredIdrPeriod = null,
            uint? preferredConsecutiveBFrameCount = null,
            uint? preferredSubLayerCount = null,
            VideoEncodeH265QpKHR? preferredConstantQp = null,
            uint? preferredMaxL0ReferenceCount = null,
            uint? preferredMaxL1ReferenceCount = null
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

            if (preferredRateControlFlags is not null)
            {
                PreferredRateControlFlags = preferredRateControlFlags.Value;
            }

            if (preferredGopFrameCount is not null)
            {
                PreferredGopFrameCount = preferredGopFrameCount.Value;
            }

            if (preferredIdrPeriod is not null)
            {
                PreferredIdrPeriod = preferredIdrPeriod.Value;
            }

            if (preferredConsecutiveBFrameCount is not null)
            {
                PreferredConsecutiveBFrameCount = preferredConsecutiveBFrameCount.Value;
            }

            if (preferredSubLayerCount is not null)
            {
                PreferredSubLayerCount = preferredSubLayerCount.Value;
            }

            if (preferredConstantQp is not null)
            {
                PreferredConstantQp = preferredConstantQp.Value;
            }

            if (preferredMaxL0ReferenceCount is not null)
            {
                PreferredMaxL0ReferenceCount = preferredMaxL0ReferenceCount.Value;
            }

            if (preferredMaxL1ReferenceCount is not null)
            {
                PreferredMaxL1ReferenceCount = preferredMaxL1ReferenceCount.Value;
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
        [NativeName("Type", "VkVideoEncodeH265RateControlFlagsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeH265RateControlFlagsKHR")]
        [NativeName("Name", "preferredRateControlFlags")]
        public VideoEncodeH265RateControlFlagsKHR PreferredRateControlFlags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "preferredGopFrameCount")]
        public uint PreferredGopFrameCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "preferredIdrPeriod")]
        public uint PreferredIdrPeriod;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "preferredConsecutiveBFrameCount")]
        public uint PreferredConsecutiveBFrameCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "preferredSubLayerCount")]
        public uint PreferredSubLayerCount;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH265QpKHR")]
        [NativeName("Type.Name", "VkVideoEncodeH265QpKHR")]
        [NativeName("Name", "preferredConstantQp")]
        public VideoEncodeH265QpKHR PreferredConstantQp;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "preferredMaxL0ReferenceCount")]
        public uint PreferredMaxL0ReferenceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "preferredMaxL1ReferenceCount")]
        public uint PreferredMaxL1ReferenceCount;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH265QualityLevelPropertiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
