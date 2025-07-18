// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoVP9Level : uint
{
    [SupportedApiProfile("vulkan")]
    Level1X0 = 0,

    [SupportedApiProfile("vulkan")]
    Level1X1 = 1,

    [SupportedApiProfile("vulkan")]
    Level2X0 = 2,

    [SupportedApiProfile("vulkan")]
    Level2X1 = 3,

    [SupportedApiProfile("vulkan")]
    Level3X0 = 4,

    [SupportedApiProfile("vulkan")]
    Level3X1 = 5,

    [SupportedApiProfile("vulkan")]
    Level4X0 = 6,

    [SupportedApiProfile("vulkan")]
    Level4X1 = 7,

    [SupportedApiProfile("vulkan")]
    Level5X0 = 8,

    [SupportedApiProfile("vulkan")]
    Level5X1 = 9,

    [SupportedApiProfile("vulkan")]
    Level5X2 = 10,

    [SupportedApiProfile("vulkan")]
    Level6X0 = 11,

    [SupportedApiProfile("vulkan")]
    Level6X1 = 12,

    [SupportedApiProfile("vulkan")]
    Level6X2 = 13,
}
