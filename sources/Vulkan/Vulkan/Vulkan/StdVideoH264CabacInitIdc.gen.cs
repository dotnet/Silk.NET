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
public enum StdVideoH264CabacInitIdc : uint
{
    [SupportedApiProfile("vulkan")]
    Idc0 = 0,

    [SupportedApiProfile("vulkan")]
    Idc1 = 1,

    [SupportedApiProfile("vulkan")]
    Idc2 = 2,

    [SupportedApiProfile("vulkan")]
    IdcInvalid = 0x7FFFFFFF,

    [SupportedApiProfile("vulkan")]
    IdcMaxEnum = 0x7FFFFFFF,
}
