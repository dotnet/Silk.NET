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
    [NativeName("Name", "VkPhysicalDeviceVertexAttributeDivisorFeaturesEXT")]
    public unsafe partial struct PhysicalDeviceVertexAttributeDivisorFeaturesEXT
    {
        public PhysicalDeviceVertexAttributeDivisorFeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceVertexAttributeDivisorFeaturesExt,
            void* pNext = null,
            Bool32? vertexAttributeInstanceRateDivisor = null,
            Bool32? vertexAttributeInstanceRateZeroDivisor = null
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

            if (vertexAttributeInstanceRateDivisor is not null)
            {
                VertexAttributeInstanceRateDivisor = vertexAttributeInstanceRateDivisor.Value;
            }

            if (vertexAttributeInstanceRateZeroDivisor is not null)
            {
                VertexAttributeInstanceRateZeroDivisor = vertexAttributeInstanceRateZeroDivisor.Value;
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
        [NativeName("Name", "vertexAttributeInstanceRateDivisor")]
        public Bool32 VertexAttributeInstanceRateDivisor;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "vertexAttributeInstanceRateZeroDivisor")]
        public Bool32 VertexAttributeInstanceRateZeroDivisor;
    }
}
