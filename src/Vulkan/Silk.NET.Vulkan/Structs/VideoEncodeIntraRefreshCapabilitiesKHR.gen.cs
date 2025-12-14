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
    [NativeName("Name", "VkVideoEncodeIntraRefreshCapabilitiesKHR")]
    public unsafe partial struct VideoEncodeIntraRefreshCapabilitiesKHR : IExtendsChain<VideoCapabilitiesKHR>
    {
        public VideoEncodeIntraRefreshCapabilitiesKHR
        (
            StructureType? sType = StructureType.VideoEncodeIntraRefreshCapabilitiesKhr,
            void* pNext = null,
            VideoEncodeIntraRefreshModeFlagsKHR? intraRefreshModes = null,
            uint? maxIntraRefreshCycleDuration = null,
            uint? maxIntraRefreshActiveReferencePictures = null,
            Bool32? partitionIndependentIntraRefreshRegions = null,
            Bool32? nonRectangularIntraRefreshRegions = null
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

            if (intraRefreshModes is not null)
            {
                IntraRefreshModes = intraRefreshModes.Value;
            }

            if (maxIntraRefreshCycleDuration is not null)
            {
                MaxIntraRefreshCycleDuration = maxIntraRefreshCycleDuration.Value;
            }

            if (maxIntraRefreshActiveReferencePictures is not null)
            {
                MaxIntraRefreshActiveReferencePictures = maxIntraRefreshActiveReferencePictures.Value;
            }

            if (partitionIndependentIntraRefreshRegions is not null)
            {
                PartitionIndependentIntraRefreshRegions = partitionIndependentIntraRefreshRegions.Value;
            }

            if (nonRectangularIntraRefreshRegions is not null)
            {
                NonRectangularIntraRefreshRegions = nonRectangularIntraRefreshRegions.Value;
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
        [NativeName("Type", "VkVideoEncodeIntraRefreshModeFlagsKHR")]
        [NativeName("Type.Name", "VkVideoEncodeIntraRefreshModeFlagsKHR")]
        [NativeName("Name", "intraRefreshModes")]
        public VideoEncodeIntraRefreshModeFlagsKHR IntraRefreshModes;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxIntraRefreshCycleDuration")]
        public uint MaxIntraRefreshCycleDuration;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "maxIntraRefreshActiveReferencePictures")]
        public uint MaxIntraRefreshActiveReferencePictures;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "partitionIndependentIntraRefreshRegions")]
        public Bool32 PartitionIndependentIntraRefreshRegions;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "nonRectangularIntraRefreshRegions")]
        public Bool32 NonRectangularIntraRefreshRegions;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.VideoEncodeIntraRefreshCapabilitiesKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
