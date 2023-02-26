// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkAccelerationStructureBuildTypeKHR")]
    public enum AccelerationStructureBuildTypeKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"HostKhr\"")]
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_KHR")]
        AccelerationStructureBuildTypeHostKhr = 0,
        [Obsolete("Deprecated in favour of \"DeviceKhr\"")]
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_BUILD_TYPE_DEVICE_KHR")]
        AccelerationStructureBuildTypeDeviceKhr = 1,
        [Obsolete("Deprecated in favour of \"HostOrDeviceKhr\"")]
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_OR_DEVICE_KHR")]
        AccelerationStructureBuildTypeHostOrDeviceKhr = 2,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_KHR")]
        HostKhr = 0,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_BUILD_TYPE_DEVICE_KHR")]
        DeviceKhr = 1,
        [NativeName("Name", "VK_ACCELERATION_STRUCTURE_BUILD_TYPE_HOST_OR_DEVICE_KHR")]
        HostOrDeviceKhr = 2,
    }
}
