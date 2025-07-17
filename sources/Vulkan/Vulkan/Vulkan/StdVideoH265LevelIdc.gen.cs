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
public enum StdVideoH265LevelIdc : uint
{
    [SupportedApiProfile("vulkan")]
    Idc1X0 = 0,

    [SupportedApiProfile("vulkan")]
    Idc2X0 = 1,

    [SupportedApiProfile("vulkan")]
    Idc2X1 = 2,

    [SupportedApiProfile("vulkan")]
    Idc3X0 = 3,

    [SupportedApiProfile("vulkan")]
    Idc3X1 = 4,

    [SupportedApiProfile("vulkan")]
    Idc4X0 = 5,

    [SupportedApiProfile("vulkan")]
    Idc4X1 = 6,

    [SupportedApiProfile("vulkan")]
    Idc5X0 = 7,

    [SupportedApiProfile("vulkan")]
    Idc5X1 = 8,

    [SupportedApiProfile("vulkan")]
    Idc5X2 = 9,

    [SupportedApiProfile("vulkan")]
    Idc6X0 = 10,

    [SupportedApiProfile("vulkan")]
    Idc6X1 = 11,

    [SupportedApiProfile("vulkan")]
    Idc6X2 = 12,
}
