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
[Flags]
public enum FenceImportFlags : uint
{
    None = 0,

    [SupportedApiProfile(
        "vulkan",
        ["VK_VERSION_1_1", "VK_VERSION_1_2", "VK_VERSION_1_3", "VK_VERSION_1_4"],
        MinVersion = "1.1"
    )]
    FenceImportTemporaryBit = 0x00000001,

    [SupportedApiProfile(
        "vulkan",
        ["VK_KHR_external_fence"],
        ImpliesSets = ["VK_KHR_external_fence_capabilities"]
    )]
    FenceImportTemporaryBitKHR = FenceImportTemporaryBit,
}
