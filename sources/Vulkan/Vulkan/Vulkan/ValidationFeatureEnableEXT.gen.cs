// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum ValidationFeatureEnableEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    GpuAssistedEXT = 0,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    GpuAssistedReserveBindingSlotEXT = 1,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    BestPracticesEXT = 2,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    DebugPrintfEXT = 3,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    SynchronizationValidationEXT = 4,
}
