// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDepthClampModeEXT")]
public enum DepthClampModeEXT : uint
{
    [NativeName("VK_DEPTH_CLAMP_MODE_VIEWPORT_RANGE_EXT")]
    ViewportRange = 0,

    [NativeName("VK_DEPTH_CLAMP_MODE_USER_DEFINED_RANGE_EXT")]
    UserDefinedRange = 1,
}
