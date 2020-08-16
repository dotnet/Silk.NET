// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPhysicalDeviceShaderFloat16Int8Features")]
    public unsafe partial struct PhysicalDeviceShaderFloat16Int8Features
    {
        public PhysicalDeviceShaderFloat16Int8Features
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
        [NativeName("Name", "shaderFloat16")]
        public Bool32 ShaderFloat16;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "shaderInt8")]
        public Bool32 ShaderInt8;
    }
}
