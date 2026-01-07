// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkAddressCopyFlagsKHR")]
    public enum AddressCopyFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"DeviceLocalBitKhr\"")]
        [NativeName("Name", "VK_ADDRESS_COPY_DEVICE_LOCAL_BIT_KHR")]
        AddressCopyDeviceLocalBitKhr = 1,
        [Obsolete("Deprecated in favour of \"SparseBitKhr\"")]
        [NativeName("Name", "VK_ADDRESS_COPY_SPARSE_BIT_KHR")]
        AddressCopySparseBitKhr = 2,
        [Obsolete("Deprecated in favour of \"ProtectedBitKhr\"")]
        [NativeName("Name", "VK_ADDRESS_COPY_PROTECTED_BIT_KHR")]
        AddressCopyProtectedBitKhr = 4,
        [NativeName("Name", "VK_ADDRESS_COPY_DEVICE_LOCAL_BIT_KHR")]
        DeviceLocalBitKhr = 1,
        [NativeName("Name", "VK_ADDRESS_COPY_SPARSE_BIT_KHR")]
        SparseBitKhr = 2,
        [NativeName("Name", "VK_ADDRESS_COPY_PROTECTED_BIT_KHR")]
        ProtectedBitKhr = 4,
    }
}
