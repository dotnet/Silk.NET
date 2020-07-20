// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkComponentTypeNV")]
    public enum ComponentTypeNV
    {
        [NativeName("Name", "VK_COMPONENT_TYPE_FLOAT16_NV")]
        ComponentTypeFloat16NV = 0,
        [NativeName("Name", "VK_COMPONENT_TYPE_FLOAT32_NV")]
        ComponentTypeFloat32NV = 1,
        [NativeName("Name", "VK_COMPONENT_TYPE_FLOAT64_NV")]
        ComponentTypeFloat64NV = 2,
        [NativeName("Name", "VK_COMPONENT_TYPE_SINT8_NV")]
        ComponentTypeSint8NV = 3,
        [NativeName("Name", "VK_COMPONENT_TYPE_SINT16_NV")]
        ComponentTypeSint16NV = 4,
        [NativeName("Name", "VK_COMPONENT_TYPE_SINT32_NV")]
        ComponentTypeSint32NV = 5,
        [NativeName("Name", "VK_COMPONENT_TYPE_SINT64_NV")]
        ComponentTypeSint64NV = 6,
        [NativeName("Name", "VK_COMPONENT_TYPE_UINT8_NV")]
        ComponentTypeUint8NV = 7,
        [NativeName("Name", "VK_COMPONENT_TYPE_UINT16_NV")]
        ComponentTypeUint16NV = 8,
        [NativeName("Name", "VK_COMPONENT_TYPE_UINT32_NV")]
        ComponentTypeUint32NV = 9,
        [NativeName("Name", "VK_COMPONENT_TYPE_UINT64_NV")]
        ComponentTypeUint64NV = 10,
    }
}
