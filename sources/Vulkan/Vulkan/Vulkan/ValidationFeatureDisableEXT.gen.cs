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
public enum ValidationFeatureDisableEXT
{
    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    AllEXT = 0,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    ShadersEXT = 1,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    ThreadSafetyEXT = 2,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    ApiParametersEXT = 3,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    ObjectLifetimesEXT = 4,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    CoreChecksEXT = 5,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    UniqueHandlesEXT = 6,

    [SupportedApiProfile("vulkan", ["VK_EXT_validation_features"])]
    ShaderValidationCacheEXT = 7,
}
