// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct PhysicalDeviceFragmentShaderInterlockFeaturesEXT
    {
        public PhysicalDeviceFragmentShaderInterlockFeaturesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceFragmentShaderInterlockFeaturesExt,
            void* pNext = default,
            Bool32 fragmentShaderSampleInterlock = default,
            Bool32 fragmentShaderPixelInterlock = default,
            Bool32 fragmentShaderShadingRateInterlock = default
        )
        {
           SType = sType;
           PNext = pNext;
           FragmentShaderSampleInterlock = fragmentShaderSampleInterlock;
           FragmentShaderPixelInterlock = fragmentShaderPixelInterlock;
           FragmentShaderShadingRateInterlock = fragmentShaderShadingRateInterlock;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 FragmentShaderSampleInterlock;
/// <summary></summary>
        public Bool32 FragmentShaderPixelInterlock;
/// <summary></summary>
        public Bool32 FragmentShaderShadingRateInterlock;
    }
}
