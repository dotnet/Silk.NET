// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDeviceAddressBindingTypeEXT")]
    public enum DeviceAddressBindingTypeEXT : int
    {
        [Obsolete("Deprecated in favour of \"BindExt\"")]
        [NativeName("Name", "VK_DEVICE_ADDRESS_BINDING_TYPE_BIND_EXT")]
        DeviceAddressBindingTypeBindExt = 0,
        [Obsolete("Deprecated in favour of \"UnbindExt\"")]
        [NativeName("Name", "VK_DEVICE_ADDRESS_BINDING_TYPE_UNBIND_EXT")]
        DeviceAddressBindingTypeUnbindExt = 1,
        [NativeName("Name", "VK_DEVICE_ADDRESS_BINDING_TYPE_BIND_EXT")]
        BindExt = 0,
        [NativeName("Name", "VK_DEVICE_ADDRESS_BINDING_TYPE_UNBIND_EXT")]
        UnbindExt = 1,
    }
}
