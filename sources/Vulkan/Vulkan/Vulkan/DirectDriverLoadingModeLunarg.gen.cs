// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum DirectDriverLoadingModeLunarg : uint
{
    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    ExclusiveLunarg = 0,

    [SupportedApiProfile("vulkan", ["VK_LUNARG_direct_driver_loading"])]
    InclusiveLunarg = 1,
}
