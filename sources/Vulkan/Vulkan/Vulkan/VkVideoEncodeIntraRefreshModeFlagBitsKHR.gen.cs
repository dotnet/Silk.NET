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
public enum VideoEncodeIntraRefreshModeFlagsKHR : uint
{
    [SupportedApiProfile("vulkan")]
    NoneKHR = 0,

    [SupportedApiProfile("vulkan")]
    PerPicturePartitionBitKHR = 0x00000001,

    [SupportedApiProfile("vulkan")]
    BlockBasedBitKHR = 0x00000002,

    [SupportedApiProfile("vulkan")]
    BlockRowBasedBitKHR = 0x00000004,

    [SupportedApiProfile("vulkan")]
    BlockColumnBasedBitKHR = 0x00000008,
}
