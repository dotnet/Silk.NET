// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoVP9InterpolationFilter : uint
{
    [SupportedApiProfile("vulkan")]
    Eighttap = 0,

    [SupportedApiProfile("vulkan")]
    EighttapSmooth = 1,

    [SupportedApiProfile("vulkan")]
    EighttapSharp = 2,

    [SupportedApiProfile("vulkan")]
    Bilinear = 3,

    [SupportedApiProfile("vulkan")]
    Switchable = 4,
}
