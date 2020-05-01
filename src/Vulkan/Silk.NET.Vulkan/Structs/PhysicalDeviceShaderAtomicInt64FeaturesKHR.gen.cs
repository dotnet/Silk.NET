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
    public unsafe struct PhysicalDeviceShaderAtomicInt64FeaturesKHR
    {
        public PhysicalDeviceShaderAtomicInt64FeaturesKHR
        (
            StructureType sType = StructureType.PhysicalDeviceShaderAtomicInt64Features,
            void* pNext = default,
            Bool32 shaderBufferInt64Atomics = default,
            Bool32 shaderSharedInt64Atomics = default
        )
        {
           SType = sType;
           PNext = pNext;
           ShaderBufferInt64Atomics = shaderBufferInt64Atomics;
           ShaderSharedInt64Atomics = shaderSharedInt64Atomics;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 ShaderBufferInt64Atomics;
/// <summary></summary>
        public Bool32 ShaderSharedInt64Atomics;
    }
}
