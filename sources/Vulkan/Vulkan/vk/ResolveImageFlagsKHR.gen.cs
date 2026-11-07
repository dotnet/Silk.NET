// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkResolveImageFlagsKHR")]
[Flags]
public enum ResolveImageFlagsKHR : uint
{
    None = 0x0,

    [NativeName("VK_RESOLVE_IMAGE_SKIP_TRANSFER_FUNCTION_BIT_KHR")]
    SkipTransferFunctionBit = 0x1,

    [NativeName("VK_RESOLVE_IMAGE_ENABLE_TRANSFER_FUNCTION_BIT_KHR")]
    EnableTransferFunctionBit = 0x2,
}
