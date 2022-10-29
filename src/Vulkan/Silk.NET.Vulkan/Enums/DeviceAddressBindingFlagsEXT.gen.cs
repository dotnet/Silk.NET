// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkDeviceAddressBindingFlagsEXT")]
    public enum DeviceAddressBindingFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"InternalObjectBitExt\"")]
        [NativeName("Name", "VK_DEVICE_ADDRESS_BINDING_INTERNAL_OBJECT_BIT_EXT")]
        DeviceAddressBindingInternalObjectBitExt = 1,
        [NativeName("Name", "VK_DEVICE_ADDRESS_BINDING_INTERNAL_OBJECT_BIT_EXT")]
        InternalObjectBitExt = 1,
    }
}
