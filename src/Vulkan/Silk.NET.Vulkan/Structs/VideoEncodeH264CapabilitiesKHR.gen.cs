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
    [NativeName("Name", "VkVideoEncodeH264CapabilitiesKHR")]
    public unsafe partial struct VideoEncodeH264CapabilitiesKHR : IExtendsChain<VideoCapabilitiesKHR>
    {
        public VideoEncodeH264CapabilitiesKHR
        (
            StructureType? sType = StructureType.VideoEncodeH264CapabilitiesKhr,
            void* pNext = null,
            VideoEncodeH264CapabilityFlagsKHR? flags = null,
            Video.StdVideoH264LevelIdc? maxLevelIdc = null,
            uint? maxSliceCount = null,
            uint? maxPPictureL0ReferenceCount = null,
            uint? maxBPictureL0ReferenceCount = null,
            uint? maxL1ReferenceCount = null,
            uint? maxTemporalLayerCount = null,
            Bool32? expectDyadicTemporalLayerPattern = null,
            int? minQp = null,
            int? maxQp = null,
            Bool32? prefersGopRemainingFrames = null,
            Bool32? requiresGopRemainingFrames = null,
            VideoEncodeH264StdFlagsKHR? stdSyntaxFlags = null
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

            if (maxLevelIdc is not null)
            {
                MaxLevelIdc = maxLevelIdc.Value;
            }

            if (maxSliceCount is not null)
            {
                MaxSliceCount = maxSliceCount.Value;
            }

            if (maxPPictureL0ReferenceCount is not null)
            {
                MaxPPictureL0ReferenceCount = maxPPictureL0ReferenceCount.Value;
            }

            if (maxBPictureL0ReferenceCount is not null)
            {
                MaxBPictureL0ReferenceCount = maxBPictureL0ReferenceCount.Value;
            }

            if (maxL1ReferenceCount is not null)
            {
                MaxL1ReferenceCount = maxL1ReferenceCount.Value;
            }

            if (maxTemporalLayerCount is not null)
            {
                MaxTemporalLayerCount = maxTemporalLayerCount.Value;
            }

            if (expectDyadicTemporalLayerPattern is not null)
            {
                ExpectDyadicTemporalLayerPattern = expectDyadicTemporalLayerPattern.Value;
            }

            if (minQp is not null)
            {
                MinQp = minQp.Value;
            }

            if (maxQp is not null)
            {
                MaxQp = maxQp.Value;
            }

            if (prefersGopRemainingFrames is not null)
            {
                PrefersGopRemainingFrames = prefersGopRemainingFrames.Value;
            }

            if (requiresGopRemainingFrames is not null)
            {
                RequiresGopRemainingFrames = requiresGopRemainingFrames.Value;
            }

            if (stdSyntaxFlags is not null)
            {
                StdSyntaxFlags = stdSyntaxFlags.Value;
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
        [NativeName("Type", "VkVideoEncodeH264CapabilityFlagsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeH264CapabilityFlagsKHR")]
        [NativeName("Name", "flags")]
        public VideoEncodeH264CapabilityFlagsKHR Flags;
/// <summary></summary>
        [NativeName("Type", "StdVideoH264LevelIdc")]
        [NativeName("Type.Name", "StdVideoH264LevelIdc")]
        [NativeName("Name", "maxLevelIdc")]
        public Video.StdVideoH264LevelIdc MaxLevelIdc;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSliceCount")]
        public uint MaxSliceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxPPictureL0ReferenceCount")]
        public uint MaxPPictureL0ReferenceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxBPictureL0ReferenceCount")]
        public uint MaxBPictureL0ReferenceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxL1ReferenceCount")]
        public uint MaxL1ReferenceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTemporalLayerCount")]
        public uint MaxTemporalLayerCount;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "expectDyadicTemporalLayerPattern")]
        public Bool32 ExpectDyadicTemporalLayerPattern;
/// <summary></summary>
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "minQp")]
        public int MinQp;
/// <summary></summary>
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "maxQp")]
        public int MaxQp;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "prefersGopRemainingFrames")]
        public Bool32 PrefersGopRemainingFrames;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "requiresGopRemainingFrames")]
        public Bool32 RequiresGopRemainingFrames;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH264StdFlagsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeH264StdFlagsKHR")]
        [NativeName("Name", "stdSyntaxFlags")]
        public VideoEncodeH264StdFlagsKHR StdSyntaxFlags;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH264CapabilitiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
