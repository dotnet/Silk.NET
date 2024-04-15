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
    [NativeName("Name", "VkVideoEncodeH265CapabilitiesKHR")]
    public unsafe partial struct VideoEncodeH265CapabilitiesKHR : IExtendsChain<VideoCapabilitiesKHR>
    {
        public VideoEncodeH265CapabilitiesKHR
        (
            StructureType? sType = StructureType.VideoEncodeH265CapabilitiesKhr,
            void* pNext = null,
            VideoEncodeH265CapabilityFlagsKHR? flags = null,
            Video.StdVideoH265LevelIdc? maxLevelIdc = null,
            uint? maxSliceSegmentCount = null,
            Extent2D? maxTiles = null,
            VideoEncodeH265CtbSizeFlagsKHR? ctbSizes = null,
            VideoEncodeH265TransformBlockSizeFlagsKHR? transformBlockSizes = null,
            uint? maxPPictureL0ReferenceCount = null,
            uint? maxBPictureL0ReferenceCount = null,
            uint? maxL1ReferenceCount = null,
            uint? maxSubLayerCount = null,
            Bool32? expectDyadicTemporalSubLayerPattern = null,
            int? minQp = null,
            int? maxQp = null,
            Bool32? prefersGopRemainingFrames = null,
            Bool32? requiresGopRemainingFrames = null,
            VideoEncodeH265StdFlagsKHR? stdSyntaxFlags = null
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

            if (maxSliceSegmentCount is not null)
            {
                MaxSliceSegmentCount = maxSliceSegmentCount.Value;
            }

            if (maxTiles is not null)
            {
                MaxTiles = maxTiles.Value;
            }

            if (ctbSizes is not null)
            {
                CtbSizes = ctbSizes.Value;
            }

            if (transformBlockSizes is not null)
            {
                TransformBlockSizes = transformBlockSizes.Value;
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

            if (maxSubLayerCount is not null)
            {
                MaxSubLayerCount = maxSubLayerCount.Value;
            }

            if (expectDyadicTemporalSubLayerPattern is not null)
            {
                ExpectDyadicTemporalSubLayerPattern = expectDyadicTemporalSubLayerPattern.Value;
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
        [NativeName("Type", "VkVideoEncodeH265CapabilityFlagsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeH265CapabilityFlagsKHR")]
        [NativeName("Name", "flags")]
        public VideoEncodeH265CapabilityFlagsKHR Flags;
/// <summary></summary>
        [NativeName("Type", "StdVideoH265LevelIdc")]
        [NativeName("Type.Name", "StdVideoH265LevelIdc")]
        [NativeName("Name", "maxLevelIdc")]
        public Video.StdVideoH265LevelIdc MaxLevelIdc;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSliceSegmentCount")]
        public uint MaxSliceSegmentCount;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "maxTiles")]
        public Extent2D MaxTiles;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH265CtbSizeFlagsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeH265CtbSizeFlagsKHR")]
        [NativeName("Name", "ctbSizes")]
        public VideoEncodeH265CtbSizeFlagsKHR CtbSizes;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH265TransformBlockSizeFlagsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeH265TransformBlockSizeFlagsKHR")]
        [NativeName("Name", "transformBlockSizes")]
        public VideoEncodeH265TransformBlockSizeFlagsKHR TransformBlockSizes;
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
        [NativeName("Name", "maxSubLayerCount")]
        public uint MaxSubLayerCount;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "expectDyadicTemporalSubLayerPattern")]
        public Bool32 ExpectDyadicTemporalSubLayerPattern;
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
        [NativeName("Type", "VkVideoEncodeH265StdFlagsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeH265StdFlagsKHR")]
        [NativeName("Name", "stdSyntaxFlags")]
        public VideoEncodeH265StdFlagsKHR StdSyntaxFlags;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH265CapabilitiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
