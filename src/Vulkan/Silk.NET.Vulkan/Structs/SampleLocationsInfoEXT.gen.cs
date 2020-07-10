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
    [NativeName("Name", "VkSampleLocationsInfoEXT")]
    public unsafe partial struct SampleLocationsInfoEXT
    {
        public SampleLocationsInfoEXT
        (
            StructureType sType = StructureType.SampleLocationsInfoExt,
            void* pNext = default,
            SampleCountFlags sampleLocationsPerPixel = default,
            Extent2D sampleLocationGridSize = default,
            uint sampleLocationsCount = default,
            SampleLocationEXT* pSampleLocations = default
        )
        {
            SType = sType;
            PNext = pNext;
            SampleLocationsPerPixel = sampleLocationsPerPixel;
            SampleLocationGridSize = sampleLocationGridSize;
            SampleLocationsCount = sampleLocationsCount;
            PSampleLocations = pSampleLocations;
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
    }
}
