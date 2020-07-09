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
    [NativeName("Name", "VkPhysicalDeviceFragmentDensityMapPropertiesEXT")]
    public unsafe struct PhysicalDeviceFragmentDensityMapPropertiesEXT
    {
        public PhysicalDeviceFragmentDensityMapPropertiesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceFragmentDensityMapPropertiesExt,
            void* pNext = default,
            Extent2D minFragmentDensityTexelSize = default,
            Extent2D maxFragmentDensityTexelSize = default,
            Bool32 fragmentDensityInvocations = default
        )
        {
           SType = sType;
           PNext = pNext;
           MinFragmentDensityTexelSize = minFragmentDensityTexelSize;
           MaxFragmentDensityTexelSize = maxFragmentDensityTexelSize;
           FragmentDensityInvocations = fragmentDensityInvocations;
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
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "minFragmentDensityTexelSize")]
        public Extent2D MinFragmentDensityTexelSize;
/// <summary></summary>
        [NativeName("Type", "VkExtent2D")]
        [NativeName("Type.Name", "VkExtent2D")]
        [NativeName("Name", "maxFragmentDensityTexelSize")]
        public Extent2D MaxFragmentDensityTexelSize;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "fragmentDensityInvocations")]
        public Bool32 FragmentDensityInvocations;
    }
}
