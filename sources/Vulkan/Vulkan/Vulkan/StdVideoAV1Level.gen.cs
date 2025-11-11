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
public enum StdVideoAV1Level : uint
{
    [SupportedApiProfile("vulkan")]
    Level2X0 = 0,

    [SupportedApiProfile("vulkan")]
    Level2X1 = 1,

    [SupportedApiProfile("vulkan")]
    Level2X2 = 2,

    [SupportedApiProfile("vulkan")]
    Level2X3 = 3,

    [SupportedApiProfile("vulkan")]
    Level3X0 = 4,

    [SupportedApiProfile("vulkan")]
    Level3X1 = 5,

    [SupportedApiProfile("vulkan")]
    Level3X2 = 6,

    [SupportedApiProfile("vulkan")]
    Level3X3 = 7,

    [SupportedApiProfile("vulkan")]
    Level4X0 = 8,

    [SupportedApiProfile("vulkan")]
    Level4X1 = 9,

    [SupportedApiProfile("vulkan")]
    Level4X2 = 10,

    [SupportedApiProfile("vulkan")]
    Level4X3 = 11,

    [SupportedApiProfile("vulkan")]
    Level5X0 = 12,

    [SupportedApiProfile("vulkan")]
    Level5X1 = 13,

    [SupportedApiProfile("vulkan")]
    Level5X2 = 14,

    [SupportedApiProfile("vulkan")]
    Level5X3 = 15,

    [SupportedApiProfile("vulkan")]
    Level6X0 = 16,

    [SupportedApiProfile("vulkan")]
    Level6X1 = 17,

    [SupportedApiProfile("vulkan")]
    Level6X2 = 18,

    [SupportedApiProfile("vulkan")]
    Level6X3 = 19,

    [SupportedApiProfile("vulkan")]
    Level7X0 = 20,

    [SupportedApiProfile("vulkan")]
    Level7X1 = 21,

    [SupportedApiProfile("vulkan")]
    Level7X2 = 22,

    [SupportedApiProfile("vulkan")]
    Level7X3 = 23,
}
