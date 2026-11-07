// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkOpacityMicromapFormatKHR")]
public enum OpacityMicromapFormatKHR : uint
{
    [NativeName("VK_OPACITY_MICROMAP_FORMAT_2_STATE_KHR")]
    Format2State = 1,

    [NativeName("VK_OPACITY_MICROMAP_FORMAT_4_STATE_KHR")]
    Format4State = 2,

    [NativeName("VK_OPACITY_MICROMAP_FORMAT_2_STATE_EXT")]
    Format2StateEXT = Format2State,

    [NativeName("VK_OPACITY_MICROMAP_FORMAT_4_STATE_EXT")]
    Format4StateEXT = Format4State,
}
