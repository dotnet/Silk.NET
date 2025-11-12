// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH265ProfileIdc : uint
{
    [SupportedApiProfile("vulkan")]
    Main = 1,

    [SupportedApiProfile("vulkan")]
    Main10 = 2,

    [SupportedApiProfile("vulkan")]
    MainStillPicture = 3,

    [SupportedApiProfile("vulkan")]
    FormatRangeExtensions = 4,

    [SupportedApiProfile("vulkan")]
    SccExtensions = 9,
}
