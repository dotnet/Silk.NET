// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkTessellationDomainOrigin")]
public enum TessellationDomainOrigin : uint
{
    [NativeName("VK_TESSELLATION_DOMAIN_ORIGIN_UPPER_LEFT")]
    UpperLeft = 0,

    [NativeName("VK_TESSELLATION_DOMAIN_ORIGIN_LOWER_LEFT")]
    LowerLeft = 1,

    [NativeName("VK_TESSELLATION_DOMAIN_ORIGIN_UPPER_LEFT_KHR")]
    UpperLeftKHR = UpperLeft,

    [NativeName("VK_TESSELLATION_DOMAIN_ORIGIN_LOWER_LEFT_KHR")]
    LowerLeftKHR = LowerLeft,
}
