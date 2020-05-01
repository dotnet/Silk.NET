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
    public unsafe struct PhysicalDeviceShaderFloat16Int8FeaturesKHR
    {
        public PhysicalDeviceShaderFloat16Int8FeaturesKHR
        (
            StructureType sType = StructureType.PhysicalDeviceShaderFloat16Int8Features,
            void* pNext = default,
            Bool32 shaderFloat16 = default,
            Bool32 shaderInt8 = default
        )
        {
           SType = sType;
           PNext = pNext;
           ShaderFloat16 = shaderFloat16;
           ShaderInt8 = shaderInt8;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 ShaderFloat16;
/// <summary></summary>
        public Bool32 ShaderInt8;
    }
}
