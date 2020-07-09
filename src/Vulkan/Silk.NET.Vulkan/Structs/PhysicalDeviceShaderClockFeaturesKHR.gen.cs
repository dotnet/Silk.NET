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
    [NativeName("Name", "VkPhysicalDeviceShaderClockFeaturesKHR")]
    public unsafe struct PhysicalDeviceShaderClockFeaturesKHR
    {
        public PhysicalDeviceShaderClockFeaturesKHR
        (
            StructureType sType = StructureType.PhysicalDeviceShaderClockFeaturesKhr,
            void* pNext = default,
            Bool32 shaderSubgroupClock = default,
            Bool32 shaderDeviceClock = default
        )
        {
           SType = sType;
           PNext = pNext;
           ShaderSubgroupClock = shaderSubgroupClock;
           ShaderDeviceClock = shaderDeviceClock;
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
        [NativeName("Name", "shaderSubgroupClock")]
        public Bool32 ShaderSubgroupClock;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderDeviceClock")]
        public Bool32 ShaderDeviceClock;
    }
}
