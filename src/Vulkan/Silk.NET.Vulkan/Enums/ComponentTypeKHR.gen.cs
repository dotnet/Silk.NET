// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkComponentTypeKHR")]
    public enum ComponentTypeKHR : int
    {
        [Obsolete("Deprecated in favour of \"Float16Khr\"")]
        [NativeName("Name", "VK_COMPONENT_TYPE_FLOAT16_KHR")]
        ComponentTypeFloat16Khr = 0,
        [Obsolete("Deprecated in favour of \"Float32Khr\"")]
        [NativeName("Name", "VK_COMPONENT_TYPE_FLOAT32_KHR")]
        ComponentTypeFloat32Khr = 1,
        [Obsolete("Deprecated in favour of \"Float64Khr\"")]
        [NativeName("Name", "VK_COMPONENT_TYPE_FLOAT64_KHR")]
        ComponentTypeFloat64Khr = 2,
        [Obsolete("Deprecated in favour of \"Sint8Khr\"")]
        [NativeName("Name", "VK_COMPONENT_TYPE_SINT8_KHR")]
        ComponentTypeSint8Khr = 3,
        [Obsolete("Deprecated in favour of \"Sint16Khr\"")]
        [NativeName("Name", "VK_COMPONENT_TYPE_SINT16_KHR")]
        ComponentTypeSint16Khr = 4,
        [Obsolete("Deprecated in favour of \"Sint32Khr\"")]
        [NativeName("Name", "VK_COMPONENT_TYPE_SINT32_KHR")]
        ComponentTypeSint32Khr = 5,
        [Obsolete("Deprecated in favour of \"Sint64Khr\"")]
        [NativeName("Name", "VK_COMPONENT_TYPE_SINT64_KHR")]
        ComponentTypeSint64Khr = 6,
        [Obsolete("Deprecated in favour of \"Uint8Khr\"")]
        [NativeName("Name", "VK_COMPONENT_TYPE_UINT8_KHR")]
        ComponentTypeUint8Khr = 7,
        [Obsolete("Deprecated in favour of \"Uint16Khr\"")]
        [NativeName("Name", "VK_COMPONENT_TYPE_UINT16_KHR")]
        ComponentTypeUint16Khr = 8,
        [Obsolete("Deprecated in favour of \"Uint32Khr\"")]
        [NativeName("Name", "VK_COMPONENT_TYPE_UINT32_KHR")]
        ComponentTypeUint32Khr = 9,
        [Obsolete("Deprecated in favour of \"Uint64Khr\"")]
        [NativeName("Name", "VK_COMPONENT_TYPE_UINT64_KHR")]
        ComponentTypeUint64Khr = 10,
        [NativeName("Name", "VK_COMPONENT_TYPE_FLOAT16_KHR")]
        Float16Khr = 0,
        [NativeName("Name", "VK_COMPONENT_TYPE_FLOAT32_KHR")]
        Float32Khr = 1,
        [NativeName("Name", "VK_COMPONENT_TYPE_FLOAT64_KHR")]
        Float64Khr = 2,
        [NativeName("Name", "VK_COMPONENT_TYPE_SINT8_KHR")]
        Sint8Khr = 3,
        [NativeName("Name", "VK_COMPONENT_TYPE_SINT16_KHR")]
        Sint16Khr = 4,
        [NativeName("Name", "VK_COMPONENT_TYPE_SINT32_KHR")]
        Sint32Khr = 5,
        [NativeName("Name", "VK_COMPONENT_TYPE_SINT64_KHR")]
        Sint64Khr = 6,
        [NativeName("Name", "VK_COMPONENT_TYPE_UINT8_KHR")]
        Uint8Khr = 7,
        [NativeName("Name", "VK_COMPONENT_TYPE_UINT16_KHR")]
        Uint16Khr = 8,
        [NativeName("Name", "VK_COMPONENT_TYPE_UINT32_KHR")]
        Uint32Khr = 9,
        [NativeName("Name", "VK_COMPONENT_TYPE_UINT64_KHR")]
        Uint64Khr = 10,
    }
}
