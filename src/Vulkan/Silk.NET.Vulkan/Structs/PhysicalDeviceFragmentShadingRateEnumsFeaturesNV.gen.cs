// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
    [NativeName("Name", "VkPhysicalDeviceFragmentShadingRateEnumsFeaturesNV")]
    public unsafe partial struct PhysicalDeviceFragmentShadingRateEnumsFeaturesNV
    {
        public PhysicalDeviceFragmentShadingRateEnumsFeaturesNV
        (
            StructureType? sType = StructureType.PhysicalDeviceFragmentShadingRateEnumsFeaturesNV,
            void* pNext = null,
            Bool32? fragmentShadingRateEnums = null,
            Bool32? supersampleFragmentShadingRates = null,
            Bool32? noInvocationFragmentShadingRates = null
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

            if (fragmentShadingRateEnums is not null)
            {
                FragmentShadingRateEnums = fragmentShadingRateEnums.Value;
            }

            if (supersampleFragmentShadingRates is not null)
            {
                SupersampleFragmentShadingRates = supersampleFragmentShadingRates.Value;
            }

            if (noInvocationFragmentShadingRates is not null)
            {
                NoInvocationFragmentShadingRates = noInvocationFragmentShadingRates.Value;
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "fragmentShadingRateEnums")]
        public Bool32 FragmentShadingRateEnums;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "supersampleFragmentShadingRates")]
        public Bool32 SupersampleFragmentShadingRates;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "noInvocationFragmentShadingRates")]
        public Bool32 NoInvocationFragmentShadingRates;
    }
}
