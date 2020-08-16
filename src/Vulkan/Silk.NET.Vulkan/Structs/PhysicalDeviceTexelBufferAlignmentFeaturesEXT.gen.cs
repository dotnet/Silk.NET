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
    [NativeName("Name", "VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT")]
    public unsafe partial struct PhysicalDeviceTexelBufferAlignmentFeaturesEXT
    {
        public PhysicalDeviceTexelBufferAlignmentFeaturesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceTexelBufferAlignmentFeaturesExt,
            void* pNext = default,
            Bool32 texelBufferAlignment = default
        )
        {
            SType = sType;
            PNext = pNext;
            TexelBufferAlignment = texelBufferAlignment;
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
        [NativeName("Name", "texelBufferAlignment")]
        public Bool32 TexelBufferAlignment;
    }
}
