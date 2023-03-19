// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkAccelerationStructureTypeKHR")]
    public enum AccelerationStructureTypeKHR : int
    {
        [Obsolete("Deprecated in favour of \"TopLevelKhr\"")]
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_KHR")]
        AccelerationStructureTypeTopLevelKhr = 0,
        [Obsolete("Deprecated in favour of \"BottomLevelKhr\"")]
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_KHR")]
        AccelerationStructureTypeBottomLevelKhr = 1,
        [Obsolete("Deprecated in favour of \"GenericKhr\"")]
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_TYPE_GENERIC_KHR")]
        AccelerationStructureTypeGenericKhr = 2,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_TYPE_TOP_LEVEL_KHR")]
        TopLevelKhr = 0,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_TYPE_BOTTOM_LEVEL_KHR")]
        BottomLevelKhr = 1,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_TYPE_GENERIC_KHR")]
        GenericKhr = 2,
    }
}
