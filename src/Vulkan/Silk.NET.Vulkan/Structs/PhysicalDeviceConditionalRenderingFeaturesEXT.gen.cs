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
    public unsafe struct PhysicalDeviceConditionalRenderingFeaturesEXT
    {
        public PhysicalDeviceConditionalRenderingFeaturesEXT
        (
            StructureType sType = StructureType.PhysicalDeviceConditionalRenderingFeaturesExt,
            void* pNext = default,
            Bool32 conditionalRendering = default,
            Bool32 inheritedConditionalRendering = default
        )
        {
           SType = sType;
           PNext = pNext;
           ConditionalRendering = conditionalRendering;
           InheritedConditionalRendering = inheritedConditionalRendering;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Bool32 ConditionalRendering;
/// <summary></summary>
        public Bool32 InheritedConditionalRendering;
    }
}
