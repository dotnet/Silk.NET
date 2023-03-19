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
    [NativeName("Name", "VkVideoEncodeH265CapabilitiesEXT")]
    public unsafe partial struct VideoEncodeH265CapabilitiesEXT : IExtendsChain<VideoCapabilitiesKHR>
    {
        public VideoEncodeH265CapabilitiesEXT
        (
            StructureType? sType = StructureType.VideoEncodeH265CapabilitiesExt,
            void* pNext = null,
            VideoEncodeH265CapabilityFlagsEXT? flags = null,
            VideoEncodeH265CtbSizeFlagsEXT? ctbSizes = null,
            VideoEncodeH265TransformBlockSizeFlagsEXT? transformBlockSizes = null,
            uint? maxPPictureL0ReferenceCount = null,
            uint? maxBPictureL0ReferenceCount = null,
            uint? maxL1ReferenceCount = null,
            uint? maxSubLayersCount = null,
            uint? minLog2MinLumaCodingBlockSizeMinus3 = null,
            uint? maxLog2MinLumaCodingBlockSizeMinus3 = null,
            uint? minLog2MinLumaTransformBlockSizeMinus2 = null,
            uint? maxLog2MinLumaTransformBlockSizeMinus2 = null,
            uint? minMaxTransformHierarchyDepthInter = null,
            uint? maxMaxTransformHierarchyDepthInter = null,
            uint? minMaxTransformHierarchyDepthIntra = null,
            uint? maxMaxTransformHierarchyDepthIntra = null,
            uint? maxDiffCuQpDeltaDepth = null,
            uint? minMaxNumMergeCand = null,
            uint? maxMaxNumMergeCand = null
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

            if (maxSubLayersCount is not null)
            {
                MaxSubLayersCount = maxSubLayersCount.Value;
            }

            if (minLog2MinLumaCodingBlockSizeMinus3 is not null)
            {
                MinLog2MinLumaCodingBlockSizeMinus3 = minLog2MinLumaCodingBlockSizeMinus3.Value;
            }

            if (maxLog2MinLumaCodingBlockSizeMinus3 is not null)
            {
                MaxLog2MinLumaCodingBlockSizeMinus3 = maxLog2MinLumaCodingBlockSizeMinus3.Value;
            }

            if (minLog2MinLumaTransformBlockSizeMinus2 is not null)
            {
                MinLog2MinLumaTransformBlockSizeMinus2 = minLog2MinLumaTransformBlockSizeMinus2.Value;
            }

            if (maxLog2MinLumaTransformBlockSizeMinus2 is not null)
            {
                MaxLog2MinLumaTransformBlockSizeMinus2 = maxLog2MinLumaTransformBlockSizeMinus2.Value;
            }

            if (minMaxTransformHierarchyDepthInter is not null)
            {
                MinMaxTransformHierarchyDepthInter = minMaxTransformHierarchyDepthInter.Value;
            }

            if (maxMaxTransformHierarchyDepthInter is not null)
            {
                MaxMaxTransformHierarchyDepthInter = maxMaxTransformHierarchyDepthInter.Value;
            }

            if (minMaxTransformHierarchyDepthIntra is not null)
            {
                MinMaxTransformHierarchyDepthIntra = minMaxTransformHierarchyDepthIntra.Value;
            }

            if (maxMaxTransformHierarchyDepthIntra is not null)
            {
                MaxMaxTransformHierarchyDepthIntra = maxMaxTransformHierarchyDepthIntra.Value;
            }

            if (maxDiffCuQpDeltaDepth is not null)
            {
                MaxDiffCuQpDeltaDepth = maxDiffCuQpDeltaDepth.Value;
            }

            if (minMaxNumMergeCand is not null)
            {
                MinMaxNumMergeCand = minMaxNumMergeCand.Value;
            }

            if (maxMaxNumMergeCand is not null)
            {
                MaxMaxNumMergeCand = maxMaxNumMergeCand.Value;
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
        [NativeName("Type", "VkVideoEncodeH265CapabilityFlagsEXT")]
        [NativeName("Type.Name", "VkVideoEncodeH265CapabilityFlagsEXT")]
        [NativeName("Name", "flags")]
        public VideoEncodeH265CapabilityFlagsEXT Flags;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH265CtbSizeFlagsEXT")]
        [NativeName("Type.Name", "VkVideoEncodeH265CtbSizeFlagsEXT")]
        [NativeName("Name", "ctbSizes")]
        public VideoEncodeH265CtbSizeFlagsEXT CtbSizes;
/// <summary></summary>
        [NativeName("Type", "VkVideoEncodeH265TransformBlockSizeFlagsEXT")]
        [NativeName("Type.Name", "VkVideoEncodeH265TransformBlockSizeFlagsEXT")]
        [NativeName("Name", "transformBlockSizes")]
        public VideoEncodeH265TransformBlockSizeFlagsEXT TransformBlockSizes;
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
        [NativeName("Name", "maxSubLayersCount")]
        public uint MaxSubLayersCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minLog2MinLumaCodingBlockSizeMinus3")]
        public uint MinLog2MinLumaCodingBlockSizeMinus3;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxLog2MinLumaCodingBlockSizeMinus3")]
        public uint MaxLog2MinLumaCodingBlockSizeMinus3;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minLog2MinLumaTransformBlockSizeMinus2")]
        public uint MinLog2MinLumaTransformBlockSizeMinus2;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxLog2MinLumaTransformBlockSizeMinus2")]
        public uint MaxLog2MinLumaTransformBlockSizeMinus2;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minMaxTransformHierarchyDepthInter")]
        public uint MinMaxTransformHierarchyDepthInter;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxMaxTransformHierarchyDepthInter")]
        public uint MaxMaxTransformHierarchyDepthInter;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minMaxTransformHierarchyDepthIntra")]
        public uint MinMaxTransformHierarchyDepthIntra;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxMaxTransformHierarchyDepthIntra")]
        public uint MaxMaxTransformHierarchyDepthIntra;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxDiffCuQpDeltaDepth")]
        public uint MaxDiffCuQpDeltaDepth;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "minMaxNumMergeCand")]
        public uint MinMaxNumMergeCand;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxMaxNumMergeCand")]
        public uint MaxMaxNumMergeCand;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeH265CapabilitiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
