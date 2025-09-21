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
    [NativeName("Name", "VkVideoEncodeAV1CapabilitiesKHR")]
    public unsafe partial struct VideoEncodeAV1CapabilitiesKHR : IExtendsChain<VideoCapabilitiesKHR>
    {
        public VideoEncodeAV1CapabilitiesKHR
        (
            StructureType? sType = StructureType.VideoEncodeAV1CapabilitiesKhr,
            void* pNext = null,
            VideoEncodeAV1CapabilityFlagsKHR? flags = null,
            Video.StdVideoAV1Level? maxLevel = null,
            Extent2D? codedPictureAlignment = null,
            Extent2D? maxTiles = null,
            Extent2D? minTileSize = null,
            Extent2D? maxTileSize = null,
            VideoEncodeAV1SuperblockSizeFlagsKHR? superblockSizes = null,
            uint? maxSingleReferenceCount = null,
            uint? singleReferenceNameMask = null,
            uint? maxUnidirectionalCompoundReferenceCount = null,
            uint? maxUnidirectionalCompoundGroup1ReferenceCount = null,
            uint? unidirectionalCompoundReferenceNameMask = null,
            uint? maxBidirectionalCompoundReferenceCount = null,
            uint? maxBidirectionalCompoundGroup1ReferenceCount = null,
            uint? maxBidirectionalCompoundGroup2ReferenceCount = null,
            uint? bidirectionalCompoundReferenceNameMask = null,
            uint? maxTemporalLayerCount = null,
            uint? maxSpatialLayerCount = null,
            uint? maxOperatingPoints = null,
            uint? minQIndex = null,
            uint? maxQIndex = null,
            Bool32? prefersGopRemainingFrames = null,
            Bool32? requiresGopRemainingFrames = null,
            VideoEncodeAV1StdFlagsKHR? stdSyntaxFlags = null
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

            if (maxLevel is not null)
            {
                MaxLevel = maxLevel.Value;
            }

            if (codedPictureAlignment is not null)
            {
                CodedPictureAlignment = codedPictureAlignment.Value;
            }

            if (maxTiles is not null)
            {
                MaxTiles = maxTiles.Value;
            }

            if (minTileSize is not null)
            {
                MinTileSize = minTileSize.Value;
            }

            if (maxTileSize is not null)
            {
                MaxTileSize = maxTileSize.Value;
            }

            if (superblockSizes is not null)
            {
                SuperblockSizes = superblockSizes.Value;
            }

            if (maxSingleReferenceCount is not null)
            {
                MaxSingleReferenceCount = maxSingleReferenceCount.Value;
            }

            if (singleReferenceNameMask is not null)
            {
                SingleReferenceNameMask = singleReferenceNameMask.Value;
            }

            if (maxUnidirectionalCompoundReferenceCount is not null)
            {
                MaxUnidirectionalCompoundReferenceCount = maxUnidirectionalCompoundReferenceCount.Value;
            }

            if (maxUnidirectionalCompoundGroup1ReferenceCount is not null)
            {
                MaxUnidirectionalCompoundGroup1ReferenceCount = maxUnidirectionalCompoundGroup1ReferenceCount.Value;
            }

            if (unidirectionalCompoundReferenceNameMask is not null)
            {
                UnidirectionalCompoundReferenceNameMask = unidirectionalCompoundReferenceNameMask.Value;
            }

            if (maxBidirectionalCompoundReferenceCount is not null)
            {
                MaxBidirectionalCompoundReferenceCount = maxBidirectionalCompoundReferenceCount.Value;
            }

            if (maxBidirectionalCompoundGroup1ReferenceCount is not null)
            {
                MaxBidirectionalCompoundGroup1ReferenceCount = maxBidirectionalCompoundGroup1ReferenceCount.Value;
            }

            if (maxBidirectionalCompoundGroup2ReferenceCount is not null)
            {
                MaxBidirectionalCompoundGroup2ReferenceCount = maxBidirectionalCompoundGroup2ReferenceCount.Value;
            }

            if (bidirectionalCompoundReferenceNameMask is not null)
            {
                BidirectionalCompoundReferenceNameMask = bidirectionalCompoundReferenceNameMask.Value;
            }

            if (maxTemporalLayerCount is not null)
            {
                MaxTemporalLayerCount = maxTemporalLayerCount.Value;
            }

            if (maxSpatialLayerCount is not null)
            {
                MaxSpatialLayerCount = maxSpatialLayerCount.Value;
            }

            if (maxOperatingPoints is not null)
            {
                MaxOperatingPoints = maxOperatingPoints.Value;
            }

            if (minQIndex is not null)
            {
                MinQIndex = minQIndex.Value;
            }

            if (maxQIndex is not null)
            {
                MaxQIndex = maxQIndex.Value;
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
        [NativeName("Type", "VkVideoEncodeAV1CapabilityFlagsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeAV1CapabilityFlagsKHR")]
        [NativeName("Name", "flags")]
        public VideoEncodeAV1CapabilityFlagsKHR Flags;
/// <summary></summary>
        [NativeName("Type", "StdVideoAV1Level")]
        [NativeName("Type.Name", "StdVideoAV1Level")]
        [NativeName("Name", "maxLevel")]
        public Video.StdVideoAV1Level MaxLevel;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "codedPictureAlignment")]
        public Extent2D CodedPictureAlignment;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "maxTiles")]
        public Extent2D MaxTiles;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "minTileSize")]
        public Extent2D MinTileSize;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "maxTileSize")]
        public Extent2D MaxTileSize;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeAV1SuperblockSizeFlagsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeAV1SuperblockSizeFlagsKHR")]
        [NativeName("Name", "superblockSizes")]
        public VideoEncodeAV1SuperblockSizeFlagsKHR SuperblockSizes;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSingleReferenceCount")]
        public uint MaxSingleReferenceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "singleReferenceNameMask")]
        public uint SingleReferenceNameMask;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxUnidirectionalCompoundReferenceCount")]
        public uint MaxUnidirectionalCompoundReferenceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxUnidirectionalCompoundGroup1ReferenceCount")]
        public uint MaxUnidirectionalCompoundGroup1ReferenceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "unidirectionalCompoundReferenceNameMask")]
        public uint UnidirectionalCompoundReferenceNameMask;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxBidirectionalCompoundReferenceCount")]
        public uint MaxBidirectionalCompoundReferenceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxBidirectionalCompoundGroup1ReferenceCount")]
        public uint MaxBidirectionalCompoundGroup1ReferenceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxBidirectionalCompoundGroup2ReferenceCount")]
        public uint MaxBidirectionalCompoundGroup2ReferenceCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "bidirectionalCompoundReferenceNameMask")]
        public uint BidirectionalCompoundReferenceNameMask;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxTemporalLayerCount")]
        public uint MaxTemporalLayerCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxSpatialLayerCount")]
        public uint MaxSpatialLayerCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxOperatingPoints")]
        public uint MaxOperatingPoints;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minQIndex")]
        public uint MinQIndex;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxQIndex")]
        public uint MaxQIndex;
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
        [NativeName("Type", "VkVideoEncodeAV1StdFlagsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeAV1StdFlagsKHR")]
        [NativeName("Name", "stdSyntaxFlags")]
        public VideoEncodeAV1StdFlagsKHR StdSyntaxFlags;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeAV1CapabilitiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
