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
    [NativeName("Name", "VkSampleLocationsInfoEXT")]
    public unsafe partial struct SampleLocationsInfoEXT : IExtendsChain<ImageMemoryBarrier>, IExtendsChain<ImageMemoryBarrier2KHR>
    {
        public SampleLocationsInfoEXT
        (
            StructureType? sType = StructureType.SampleLocationsInfoExt,
            void* pNext = null,
            SampleCountFlags? sampleLocationsPerPixel = null,
            Extent2D? sampleLocationGridSize = null,
            uint? sampleLocationsCount = null,
            SampleLocationEXT* pSampleLocations = null
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

            if (sampleLocationsPerPixel is not null)
            {
                SampleLocationsPerPixel = sampleLocationsPerPixel.Value;
            }

            if (sampleLocationGridSize is not null)
            {
                SampleLocationGridSize = sampleLocationGridSize.Value;
            }

            if (sampleLocationsCount is not null)
            {
                SampleLocationsCount = sampleLocationsCount.Value;
            }

            if (pSampleLocations is not null)
            {
                PSampleLocations = pSampleLocations;
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
        [NativeName("Type", "VkSampleCountFlagBits")]
        [NativeName("Type.Name", "VkSampleCountFlagBits")]
        [NativeName("Name", "sampleLocationsPerPixel")]
        public SampleCountFlags SampleLocationsPerPixel;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "sampleLocationGridSize")]
        public Extent2D SampleLocationGridSize;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sampleLocationsCount")]
        public uint SampleLocationsCount;
/// <summary></summary>
        [NativeName("Type", "VkSampleLocationEXT*")]
        [NativeName("Type.Name", "VkSampleLocationEXT")]
        [NativeName("Name", "pSampleLocations")]
        public SampleLocationEXT* PSampleLocations;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.SampleLocationsInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
