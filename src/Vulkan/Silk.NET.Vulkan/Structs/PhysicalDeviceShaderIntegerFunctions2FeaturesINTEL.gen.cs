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
    public unsafe struct PhysicalDeviceShaderIntegerFunctions2FeaturesINTEL
    {
        public PhysicalDeviceShaderIntegerFunctions2FeaturesINTEL
        (
            StructureType sType = StructureType.PhysicalDeviceShaderIntegerFunctions2FeaturesIntel,
            void* pNext = default,
            Bool32 shaderIntegerFunctions2 = default
        )
        {
           SType = sType;
           PNext = pNext;
           ShaderIntegerFunctions2 = shaderIntegerFunctions2;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 ShaderIntegerFunctions2;
    }
}
