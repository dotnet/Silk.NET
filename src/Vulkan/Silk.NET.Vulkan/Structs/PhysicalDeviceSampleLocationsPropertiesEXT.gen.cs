// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceSampleLocationsPropertiesEXT")]
    public unsafe struct PhysicalDeviceSampleLocationsPropertiesEXT
    {
        public PhysicalDeviceSampleLocationsPropertiesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceSampleLocationsPropertiesExt,
            void* pNext = default,
            SampleCountFlags sampleLocationSampleCounts = default,
            Extent2D maxSampleLocationGridSize = default,
            uint sampleLocationSubPixelBits = default,
            Bool32 variableSampleLocations = default
        )
        {
           SType = sType;
           PNext = pNext;
           SampleLocationSampleCounts = sampleLocationSampleCounts;
           MaxSampleLocationGridSize = maxSampleLocationGridSize;
           SampleLocationSubPixelBits = sampleLocationSubPixelBits;
           VariableSampleLocations = variableSampleLocations;
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
    }
}
