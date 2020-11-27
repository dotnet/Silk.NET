// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceShaderAtomicInt64Features")]
    public unsafe partial struct PhysicalDeviceShaderAtomicInt64Features
    {
        public PhysicalDeviceShaderAtomicInt64Features
        (
            StructureType? sType = StructureType.PhysicalDeviceShaderAtomicInt64Features,
            void* pNext = null,
            Bool32? shaderBufferInt64Atomics = null,
            Bool32? shaderSharedInt64Atomics = null
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

            if (shaderBufferInt64Atomics is not null)
            {
                ShaderBufferInt64Atomics = shaderBufferInt64Atomics.Value;
            }

            if (shaderSharedInt64Atomics is not null)
            {
                ShaderSharedInt64Atomics = shaderSharedInt64Atomics.Value;
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
        [NativeName("Name", "shaderBufferInt64Atomics")]
        public Bool32 ShaderBufferInt64Atomics;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderSharedInt64Atomics")]
        public Bool32 ShaderSharedInt64Atomics;
    }
}
