// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkValidationCheckEXT")]
[SupportedApiProfile("vulkan")]
public enum ValidationCheckEXT : uint
{
    [NativeName("VK_VALIDATION_CHECK_ALL_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_flags"])]
    All = 0,

    [NativeName("VK_VALIDATION_CHECK_SHADERS_EXT")]
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_flags"])]
    Shaders = 1,
}
