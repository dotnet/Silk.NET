// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDeviceFaultVendorBinaryHeaderVersionEXT")]
    public enum DeviceFaultVendorBinaryHeaderVersionEXT : int
    {
        [Obsolete("Deprecated in favour of \"OneExt\"")]
        [NativeName("Name", "VK_DEVICE_FAULT_VENDOR_BINARY_HEADER_VERSION_ONE_EXT")]
        DeviceFaultVendorBinaryHeaderVersionOneExt = 1,
        [NativeName("Name", "VK_DEVICE_FAULT_VENDOR_BINARY_HEADER_VERSION_ONE_EXT")]
        OneExt = 1,
    }
}
