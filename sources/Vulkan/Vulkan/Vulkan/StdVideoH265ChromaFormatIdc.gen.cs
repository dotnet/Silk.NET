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
public enum StdVideoH265ChromaFormatIdc : uint
{
    [SupportedApiProfile("vulkan")]
    IdcMonochrome = 0,

    [SupportedApiProfile("vulkan")]
    Idc420 = 1,

    [SupportedApiProfile("vulkan")]
    Idc422 = 2,

    [SupportedApiProfile("vulkan")]
    Idc444 = 3,
}
