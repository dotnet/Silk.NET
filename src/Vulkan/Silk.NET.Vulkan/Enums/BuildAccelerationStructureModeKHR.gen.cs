// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkBuildAccelerationStructureModeKHR")]
    public enum BuildAccelerationStructureModeKHR : int
    {
        [Obsolete("Deprecated in favour of \"BuildKhr\"")]
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_MODE_BUILD_KHR")]
        BuildAccelerationStructureModeBuildKhr = 0,
        [Obsolete("Deprecated in favour of \"UpdateKhr\"")]
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_MODE_UPDATE_KHR")]
        BuildAccelerationStructureModeUpdateKhr = 1,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_MODE_BUILD_KHR")]
        BuildKhr = 0,
        [NativeName("Name", "VK_BUILD_ACCELERATION_STRUCTURE_MODE_UPDATE_KHR")]
        UpdateKhr = 1,
    }
}
