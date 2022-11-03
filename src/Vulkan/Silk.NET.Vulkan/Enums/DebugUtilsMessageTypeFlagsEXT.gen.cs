// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkDebugUtilsMessageTypeFlagsEXT")]
    public enum DebugUtilsMessageTypeFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"GeneralBitExt\"")]
        [NativeName("Name", "VK_DEBUG_UTILS_MESSAGE_TYPE_GENERAL_BIT_EXT")]
        DebugUtilsMessageTypeGeneralBitExt = 1,
        [Obsolete("Deprecated in favour of \"ValidationBitExt\"")]
        [NativeName("Name", "VK_DEBUG_UTILS_MESSAGE_TYPE_VALIDATION_BIT_EXT")]
        DebugUtilsMessageTypeValidationBitExt = 2,
        [Obsolete("Deprecated in favour of \"PerformanceBitExt\"")]
        [NativeName("Name", "VK_DEBUG_UTILS_MESSAGE_TYPE_PERFORMANCE_BIT_EXT")]
        DebugUtilsMessageTypePerformanceBitExt = 4,
        [Obsolete("Deprecated in favour of \"DeviceAddressBindingBitExt\"")]
        [NativeName("Name", "VK_DEBUG_UTILS_MESSAGE_TYPE_DEVICE_ADDRESS_BINDING_BIT_EXT")]
        DebugUtilsMessageTypeDeviceAddressBindingBitExt = 8,
        [NativeName("Name", "VK_DEBUG_UTILS_MESSAGE_TYPE_GENERAL_BIT_EXT")]
        GeneralBitExt = 1,
        [NativeName("Name", "VK_DEBUG_UTILS_MESSAGE_TYPE_VALIDATION_BIT_EXT")]
        ValidationBitExt = 2,
        [NativeName("Name", "VK_DEBUG_UTILS_MESSAGE_TYPE_PERFORMANCE_BIT_EXT")]
        PerformanceBitExt = 4,
        [NativeName("Name", "VK_DEBUG_UTILS_MESSAGE_TYPE_DEVICE_ADDRESS_BINDING_BIT_EXT")]
        DeviceAddressBindingBitExt = 8,
    }
}
