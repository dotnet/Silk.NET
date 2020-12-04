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
    [NativeName("Name", "VkPhysicalDeviceConditionalRenderingFeaturesEXT")]
    public unsafe partial struct PhysicalDeviceConditionalRenderingFeaturesEXT
    {
        public PhysicalDeviceConditionalRenderingFeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceConditionalRenderingFeaturesExt,
            void* pNext = null,
            Bool32? conditionalRendering = null,
            Bool32? inheritedConditionalRendering = null
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

            if (conditionalRendering is not null)
            {
                ConditionalRendering = conditionalRendering.Value;
            }

            if (inheritedConditionalRendering is not null)
            {
                InheritedConditionalRendering = inheritedConditionalRendering.Value;
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
        [NativeName("Name", "conditionalRendering")]
        public Bool32 ConditionalRendering;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "inheritedConditionalRendering")]
        public Bool32 InheritedConditionalRendering;
    }
}
