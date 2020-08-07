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
    public unsafe struct PhysicalDeviceShaderAtomicFloatFeaturesEXT
    {
        public PhysicalDeviceShaderAtomicFloatFeaturesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceShaderAtomicFloatFeaturesExt,
            void* pNext = default,
            Bool32 shaderBufferFloat32Atomics = default,
            Bool32 shaderBufferFloat32AtomicAdd = default,
            Bool32 shaderBufferFloat64Atomics = default,
            Bool32 shaderBufferFloat64AtomicAdd = default,
            Bool32 shaderSharedFloat32Atomics = default,
            Bool32 shaderSharedFloat32AtomicAdd = default,
            Bool32 shaderSharedFloat64Atomics = default,
            Bool32 shaderSharedFloat64AtomicAdd = default,
            Bool32 shaderImageFloat32Atomics = default,
            Bool32 shaderImageFloat32AtomicAdd = default,
            Bool32 sparseImageFloat32Atomics = default,
            Bool32 sparseImageFloat32AtomicAdd = default
        )
        {
           SType = sType;
           PNext = pNext;
           ShaderBufferFloat32Atomics = shaderBufferFloat32Atomics;
           ShaderBufferFloat32AtomicAdd = shaderBufferFloat32AtomicAdd;
           ShaderBufferFloat64Atomics = shaderBufferFloat64Atomics;
           ShaderBufferFloat64AtomicAdd = shaderBufferFloat64AtomicAdd;
           ShaderSharedFloat32Atomics = shaderSharedFloat32Atomics;
           ShaderSharedFloat32AtomicAdd = shaderSharedFloat32AtomicAdd;
           ShaderSharedFloat64Atomics = shaderSharedFloat64Atomics;
           ShaderSharedFloat64AtomicAdd = shaderSharedFloat64AtomicAdd;
           ShaderImageFloat32Atomics = shaderImageFloat32Atomics;
           ShaderImageFloat32AtomicAdd = shaderImageFloat32AtomicAdd;
           SparseImageFloat32Atomics = sparseImageFloat32Atomics;
           SparseImageFloat32AtomicAdd = sparseImageFloat32AtomicAdd;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 ShaderBufferFloat32Atomics;
/// <summary></summary>
        public Bool32 ShaderBufferFloat32AtomicAdd;
/// <summary></summary>
        public Bool32 ShaderBufferFloat64Atomics;
/// <summary></summary>
        public Bool32 ShaderBufferFloat64AtomicAdd;
/// <summary></summary>
        public Bool32 ShaderSharedFloat32Atomics;
/// <summary></summary>
        public Bool32 ShaderSharedFloat32AtomicAdd;
/// <summary></summary>
        public Bool32 ShaderSharedFloat64Atomics;
/// <summary></summary>
        public Bool32 ShaderSharedFloat64AtomicAdd;
/// <summary></summary>
        public Bool32 ShaderImageFloat32Atomics;
/// <summary></summary>
        public Bool32 ShaderImageFloat32AtomicAdd;
/// <summary></summary>
        public Bool32 SparseImageFloat32Atomics;
/// <summary></summary>
        public Bool32 SparseImageFloat32AtomicAdd;
    }
}
