// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkAccelerationStructureCompatibilityKHR")]
    public enum AccelerationStructureCompatibilityKHR : int
    {
        [Obsolete("Deprecated in favour of \"CompatibleKhr\"")]
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_COMPATIBILITY_COMPATIBLE_KHR")]
        AccelerationStructureCompatibilityCompatibleKhr = 0,
        [Obsolete("Deprecated in favour of \"IncompatibleKhr\"")]
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_COMPATIBILITY_INCOMPATIBLE_KHR")]
        AccelerationStructureCompatibilityIncompatibleKhr = 1,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_COMPATIBILITY_COMPATIBLE_KHR")]
        CompatibleKhr = 0,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_COMPATIBILITY_INCOMPATIBLE_KHR")]
        IncompatibleKhr = 1,
    }
}
