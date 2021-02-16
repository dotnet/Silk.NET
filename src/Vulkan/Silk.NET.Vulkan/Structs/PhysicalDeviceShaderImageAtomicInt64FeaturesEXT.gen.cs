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
    [NativeName("Name", "VkPhysicalDeviceShaderImageAtomicInt64FeaturesEXT")]
    public unsafe partial struct PhysicalDeviceShaderImageAtomicInt64FeaturesEXT
    {
        public PhysicalDeviceShaderImageAtomicInt64FeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceShaderImageAtomicInt64FeaturesExt,
            void* pNext = null,
            Bool32? shaderImageInt64Atomics = null,
            Bool32? sparseImageInt64Atomics = null
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

            if (shaderImageInt64Atomics is not null)
            {
                ShaderImageInt64Atomics = shaderImageInt64Atomics.Value;
            }

            if (sparseImageInt64Atomics is not null)
            {
                SparseImageInt64Atomics = sparseImageInt64Atomics.Value;
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
        [NativeName("Name", "shaderImageInt64Atomics")]
        public Bool32 ShaderImageInt64Atomics;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "sparseImageInt64Atomics")]
        public Bool32 SparseImageInt64Atomics;
    }
}
