// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAddressCopyFlagsKHR")]
[Flags]
public enum AddressCopyFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_ADDRESS_COPY_DEVICE_LOCAL_BIT_KHR")]
    DeviceLocalBit = 0x1,

    [NativeName("VK_ADDRESS_COPY_SPARSE_BIT_KHR")]
    SparseBit = 0x2,

    [NativeName("VK_ADDRESS_COPY_PROTECTED_BIT_KHR")]
    ProtectedBit = 0x4,
}
