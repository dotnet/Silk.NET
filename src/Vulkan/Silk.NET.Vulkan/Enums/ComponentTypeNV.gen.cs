// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkComponentTypeNV")]
    public enum ComponentTypeNV : int
    {
        [Obsolete("Deprecated in favour of \"Float16NV\"")]
        [NativeName("Name", "VK_COMPONENT_TYPE_FLOAT16_NV")]
        ComponentTypeFloat16NV = 0,
        [Obsolete("Deprecated in favour of \"Float32NV\"")]
        [NativeName("Name", "VK_COMPONENT_TYPE_FLOAT32_NV")]
        ComponentTypeFloat32NV = 1,
        [Obsolete("Deprecated in favour of \"Float64NV\"")]
        [NativeName("Name", "VK_COMPONENT_TYPE_FLOAT64_NV")]
        ComponentTypeFloat64NV = 2,
        [Obsolete("Deprecated in favour of \"Sint8NV\"")]
        [NativeName("Name", "VK_COMPONENT_TYPE_SINT8_NV")]
        ComponentTypeSint8NV = 3,
        [Obsolete("Deprecated in favour of \"Sint16NV\"")]
        [NativeName("Name", "VK_COMPONENT_TYPE_SINT16_NV")]
        ComponentTypeSint16NV = 4,
        [Obsolete("Deprecated in favour of \"Sint32NV\"")]
        [NativeName("Name", "VK_COMPONENT_TYPE_SINT32_NV")]
        ComponentTypeSint32NV = 5,
        [Obsolete("Deprecated in favour of \"Sint64NV\"")]
        [NativeName("Name", "VK_COMPONENT_TYPE_SINT64_NV")]
        ComponentTypeSint64NV = 6,
        [Obsolete("Deprecated in favour of \"Uint8NV\"")]
        [NativeName("Name", "VK_COMPONENT_TYPE_UINT8_NV")]
        ComponentTypeUint8NV = 7,
        [Obsolete("Deprecated in favour of \"Uint16NV\"")]
        [NativeName("Name", "VK_COMPONENT_TYPE_UINT16_NV")]
        ComponentTypeUint16NV = 8,
        [Obsolete("Deprecated in favour of \"Uint32NV\"")]
        [NativeName("Name", "VK_COMPONENT_TYPE_UINT32_NV")]
        ComponentTypeUint32NV = 9,
        [Obsolete("Deprecated in favour of \"Uint64NV\"")]
        [NativeName("Name", "VK_COMPONENT_TYPE_UINT64_NV")]
        ComponentTypeUint64NV = 10,
        [NativeName("Name", "VK_COMPONENT_TYPE_FLOAT16_NV")]
        Float16NV = 0,
        [NativeName("Name", "VK_COMPONENT_TYPE_FLOAT32_NV")]
        Float32NV = 1,
        [NativeName("Name", "VK_COMPONENT_TYPE_FLOAT64_NV")]
        Float64NV = 2,
        [NativeName("Name", "VK_COMPONENT_TYPE_SINT8_NV")]
        Sint8NV = 3,
        [NativeName("Name", "VK_COMPONENT_TYPE_SINT16_NV")]
        Sint16NV = 4,
        [NativeName("Name", "VK_COMPONENT_TYPE_SINT32_NV")]
        Sint32NV = 5,
        [NativeName("Name", "VK_COMPONENT_TYPE_SINT64_NV")]
        Sint64NV = 6,
        [NativeName("Name", "VK_COMPONENT_TYPE_UINT8_NV")]
        Uint8NV = 7,
        [NativeName("Name", "VK_COMPONENT_TYPE_UINT16_NV")]
        Uint16NV = 8,
        [NativeName("Name", "VK_COMPONENT_TYPE_UINT32_NV")]
        Uint32NV = 9,
        [NativeName("Name", "VK_COMPONENT_TYPE_UINT64_NV")]
        Uint64NV = 10,
    }
}
