// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH265AspectRatioIdc
{
    [SupportedApiProfile("vulkan")]
    IdcUnspecified = 0,

    [SupportedApiProfile("vulkan")]
    IdcSquare = 1,

    [SupportedApiProfile("vulkan")]
    Idc12X11 = 2,

    [SupportedApiProfile("vulkan")]
    Idc10X11 = 3,

    [SupportedApiProfile("vulkan")]
    Idc16X11 = 4,

    [SupportedApiProfile("vulkan")]
    Idc40X33 = 5,

    [SupportedApiProfile("vulkan")]
    Idc24X11 = 6,

    [SupportedApiProfile("vulkan")]
    Idc20X11 = 7,

    [SupportedApiProfile("vulkan")]
    Idc32X11 = 8,

    [SupportedApiProfile("vulkan")]
    Idc80X33 = 9,

    [SupportedApiProfile("vulkan")]
    Idc18X11 = 10,

    [SupportedApiProfile("vulkan")]
    Idc15X11 = 11,

    [SupportedApiProfile("vulkan")]
    Idc64X33 = 12,

    [SupportedApiProfile("vulkan")]
    Idc160X99 = 13,

    [SupportedApiProfile("vulkan")]
    Idc4X3 = 14,

    [SupportedApiProfile("vulkan")]
    Idc3X2 = 15,

    [SupportedApiProfile("vulkan")]
    Idc2X1 = 16,

    [SupportedApiProfile("vulkan")]
    IdcExtendedSar = 255,
}
