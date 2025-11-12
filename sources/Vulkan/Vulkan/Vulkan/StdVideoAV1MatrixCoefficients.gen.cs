// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoAV1MatrixCoefficients : uint
{
    [SupportedApiProfile("vulkan")]
    Identity = 0,

    [SupportedApiProfile("vulkan")]
    Bt709 = 1,

    [SupportedApiProfile("vulkan")]
    Unspecified = 2,

    [SupportedApiProfile("vulkan")]
    Reserved3 = 3,

    [SupportedApiProfile("vulkan")]
    Fcc = 4,

    [SupportedApiProfile("vulkan")]
    Bt470BG = 5,

    [SupportedApiProfile("vulkan")]
    Bt601 = 6,

    [SupportedApiProfile("vulkan")]
    Smpte240 = 7,

    [SupportedApiProfile("vulkan")]
    SmpteYcgco = 8,

    [SupportedApiProfile("vulkan")]
    Bt2020Ncl = 9,

    [SupportedApiProfile("vulkan")]
    Bt2020Cl = 10,

    [SupportedApiProfile("vulkan")]
    Smpte2085 = 11,

    [SupportedApiProfile("vulkan")]
    ChromatNcl = 12,

    [SupportedApiProfile("vulkan")]
    ChromatCl = 13,

    [SupportedApiProfile("vulkan")]
    Ictcp = 14,
}
