// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAddressCommandFlagsKHR")]
[Flags]
public enum AddressCommandFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_ADDRESS_COMMAND_PROTECTED_BIT_KHR")]
    ProtectedBit = 0x1,

    [NativeName("VK_ADDRESS_COMMAND_FULLY_BOUND_BIT_KHR")]
    FullyBoundBit = 0x2,

    [NativeName("VK_ADDRESS_COMMAND_STORAGE_BUFFER_USAGE_BIT_KHR")]
    StorageBufferUsageBit = 0x4,

    [NativeName("VK_ADDRESS_COMMAND_UNKNOWN_STORAGE_BUFFER_USAGE_BIT_KHR")]
    UnknownStorageBufferUsageBit = 0x8,

    [NativeName("VK_ADDRESS_COMMAND_TRANSFORM_FEEDBACK_BUFFER_USAGE_BIT_KHR")]
    TransformFeedbackBufferUsageBit = 0x10,

    [NativeName("VK_ADDRESS_COMMAND_UNKNOWN_TRANSFORM_FEEDBACK_BUFFER_USAGE_BIT_KHR")]
    UnknownTransformFeedbackBufferUsageBit = 0x20,
}
