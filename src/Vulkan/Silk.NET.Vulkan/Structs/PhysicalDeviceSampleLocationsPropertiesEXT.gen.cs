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
    [NativeName("Name", "VkPhysicalDeviceSampleLocationsPropertiesEXT")]
    public unsafe partial struct PhysicalDeviceSampleLocationsPropertiesEXT : IExtendsChain<PhysicalDeviceProperties2>, IExtendsChain<PhysicalDeviceProperties2KHR>
    {
        public PhysicalDeviceSampleLocationsPropertiesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceSampleLocationsPropertiesExt,
            void* pNext = null,
            SampleCountFlags? sampleLocationSampleCounts = null,
            Extent2D? maxSampleLocationGridSize = null,
            uint? sampleLocationSubPixelBits = null,
            Bool32? variableSampleLocations = null
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

            if (sampleLocationSampleCounts is not null)
            {
                SampleLocationSampleCounts = sampleLocationSampleCounts.Value;
            }

            if (maxSampleLocationGridSize is not null)
            {
                MaxSampleLocationGridSize = maxSampleLocationGridSize.Value;
            }

            if (sampleLocationSubPixelBits is not null)
            {
                SampleLocationSubPixelBits = sampleLocationSubPixelBits.Value;
            }

            if (variableSampleLocations is not null)
            {
                VariableSampleLocations = variableSampleLocations.Value;
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
        [NativeName("Type", "VkSampleCountFlags")]
        [NativeName("Type.Name", "VkSampleCountFlags")]
        [NativeName("Name", "sampleLocationSampleCounts")]
        public SampleCountFlags SampleLocationSampleCounts;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "maxSampleLocationGridSize")]
        public Extent2D MaxSampleLocationGridSize;
        /// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "sampleLocationCoordinateRange")]
        public fixed float SampleLocationCoordinateRange[2];
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sampleLocationSubPixelBits")]
        public uint SampleLocationSubPixelBits;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "variableSampleLocations")]
        public Bool32 VariableSampleLocations;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceSampleLocationsPropertiesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
