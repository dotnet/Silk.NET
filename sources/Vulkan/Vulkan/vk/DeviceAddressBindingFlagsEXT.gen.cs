// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDeviceAddressBindingFlagsEXT")]
[Flags]
public enum DeviceAddressBindingFlagsEXT : uint
{
    None = 0x0,

    [NativeName("VK_DEVICE_ADDRESS_BINDING_INTERNAL_OBJECT_BIT_EXT")]
    InternalObjectBit = 0x1,
}
