// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeRateControlModeFlagsKHR")]
[Flags]
public enum VideoEncodeRateControlModeFlagsKHR : uint
{
    [NativeName("VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DEFAULT_KHR")]
    Default = 0x0,

    [NativeName("VK_VIDEO_ENCODE_RATE_CONTROL_MODE_DISABLED_BIT_KHR")]
    DisabledBit = 0x1,

    [NativeName("VK_VIDEO_ENCODE_RATE_CONTROL_MODE_CBR_BIT_KHR")]
    CbrBit = 0x2,

    [NativeName("VK_VIDEO_ENCODE_RATE_CONTROL_MODE_VBR_BIT_KHR")]
    VbrBit = 0x4,
}
