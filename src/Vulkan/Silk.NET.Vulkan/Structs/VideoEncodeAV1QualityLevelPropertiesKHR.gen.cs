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
    [NativeName("Name", "VkVideoEncodeAV1QualityLevelPropertiesKHR")]
    public unsafe partial struct VideoEncodeAV1QualityLevelPropertiesKHR : IExtendsChain<VideoEncodeQualityLevelPropertiesKHR>
    {
        public VideoEncodeAV1QualityLevelPropertiesKHR
        (
            StructureType? sType = StructureType.VideoEncodeAV1QualityLevelPropertiesKhr,
            void* pNext = null,
            VideoEncodeAV1RateControlFlagsKHR? preferredRateControlFlags = null,
            uint? preferredGopFrameCount = null,
            uint? preferredKeyFramePeriod = null,
            uint? preferredConsecutiveBipredictiveFrameCount = null,
            uint? preferredTemporalLayerCount = null,
            VideoEncodeAV1QIndexKHR? preferredConstantQIndex = null,
            uint? preferredMaxSingleReferenceCount = null,
            uint? preferredSingleReferenceNameMask = null,
            uint? preferredMaxUnidirectionalCompoundReferenceCount = null,
            uint? preferredMaxUnidirectionalCompoundGroup1ReferenceCount = null,
            uint? preferredUnidirectionalCompoundReferenceNameMask = null,
            uint? preferredMaxBidirectionalCompoundReferenceCount = null,
            uint? preferredMaxBidirectionalCompoundGroup1ReferenceCount = null,
            uint? preferredMaxBidirectionalCompoundGroup2ReferenceCount = null,
            uint? preferredBidirectionalCompoundReferenceNameMask = null
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

            if (preferredKeyFramePeriod is not null)
            {
                PreferredKeyFramePeriod = preferredKeyFramePeriod.Value;
            }

            if (preferredConsecutiveBipredictiveFrameCount is not null)
            {
                PreferredConsecutiveBipredictiveFrameCount = preferredConsecutiveBipredictiveFrameCount.Value;
            }

            if (preferredTemporalLayerCount is not null)
            {
                PreferredTemporalLayerCount = preferredTemporalLayerCount.Value;
            }

            if (preferredConstantQIndex is not null)
            {
                PreferredConstantQIndex = preferredConstantQIndex.Value;
            }

            if (preferredMaxSingleReferenceCount is not null)
            {
                PreferredMaxSingleReferenceCount = preferredMaxSingleReferenceCount.Value;
            }

            if (preferredSingleReferenceNameMask is not null)
            {
                PreferredSingleReferenceNameMask = preferredSingleReferenceNameMask.Value;
            }

            if (preferredMaxUnidirectionalCompoundReferenceCount is not null)
            {
                PreferredMaxUnidirectionalCompoundReferenceCount = preferredMaxUnidirectionalCompoundReferenceCount.Value;
            }

            if (preferredMaxUnidirectionalCompoundGroup1ReferenceCount is not null)
            {
                PreferredMaxUnidirectionalCompoundGroup1ReferenceCount = preferredMaxUnidirectionalCompoundGroup1ReferenceCount.Value;
            }

            if (preferredUnidirectionalCompoundReferenceNameMask is not null)
            {
                PreferredUnidirectionalCompoundReferenceNameMask = preferredUnidirectionalCompoundReferenceNameMask.Value;
            }

            if (preferredMaxBidirectionalCompoundReferenceCount is not null)
            {
                PreferredMaxBidirectionalCompoundReferenceCount = preferredMaxBidirectionalCompoundReferenceCount.Value;
            }

            if (preferredMaxBidirectionalCompoundGroup1ReferenceCount is not null)
            {
                PreferredMaxBidirectionalCompoundGroup1ReferenceCount = preferredMaxBidirectionalCompoundGroup1ReferenceCount.Value;
            }

            if (preferredMaxBidirectionalCompoundGroup2ReferenceCount is not null)
            {
                PreferredMaxBidirectionalCompoundGroup2ReferenceCount = preferredMaxBidirectionalCompoundGroup2ReferenceCount.Value;
            }

            if (preferredBidirectionalCompoundReferenceNameMask is not null)
            {
                PreferredBidirectionalCompoundReferenceNameMask = preferredBidirectionalCompoundReferenceNameMask.Value;
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
        [NativeName("Name", "preferredRateControlFlags")]
        public VideoEncodeAV1RateControlFlagsKHR PreferredRateControlFlags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "preferredGopFrameCount")]
        public uint PreferredGopFrameCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "preferredKeyFramePeriod")]
        public uint PreferredKeyFramePeriod;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "preferredConsecutiveBipredictiveFrameCount")]
        public uint PreferredConsecutiveBipredictiveFrameCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "preferredTemporalLayerCount")]
        public uint PreferredTemporalLayerCount;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeAV1QIndexKHR")]
        [NativeName("Type.Name", "VkVideoEncodeAV1QIndexKHR")]
        [NativeName("Name", "preferredConstantQIndex")]
        public VideoEncodeAV1QIndexKHR PreferredConstantQIndex;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "preferredMaxSingleReferenceCount")]
        public uint PreferredMaxSingleReferenceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "preferredSingleReferenceNameMask")]
        public uint PreferredSingleReferenceNameMask;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "preferredMaxUnidirectionalCompoundReferenceCount")]
        public uint PreferredMaxUnidirectionalCompoundReferenceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "preferredMaxUnidirectionalCompoundGroup1ReferenceCount")]
        public uint PreferredMaxUnidirectionalCompoundGroup1ReferenceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "preferredUnidirectionalCompoundReferenceNameMask")]
        public uint PreferredUnidirectionalCompoundReferenceNameMask;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "preferredMaxBidirectionalCompoundReferenceCount")]
        public uint PreferredMaxBidirectionalCompoundReferenceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "preferredMaxBidirectionalCompoundGroup1ReferenceCount")]
        public uint PreferredMaxBidirectionalCompoundGroup1ReferenceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "preferredMaxBidirectionalCompoundGroup2ReferenceCount")]
        public uint PreferredMaxBidirectionalCompoundGroup2ReferenceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "preferredBidirectionalCompoundReferenceNameMask")]
        public uint PreferredBidirectionalCompoundReferenceNameMask;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeAV1QualityLevelPropertiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
