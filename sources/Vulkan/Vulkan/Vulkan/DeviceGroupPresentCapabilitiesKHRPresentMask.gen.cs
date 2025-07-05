// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[InlineArray(32)]
[SupportedApiProfile(
    "vulkan",
    ["VK_KHR_swapchain", "VK_VERSION_1_1"],
    ImpliesSets = ["VK_KHR_surface"],
    RequireAll = true
)]
public partial struct DeviceGroupPresentCapabilitiesKHRPresentMask
{
    [SupportedApiProfile("vulkan")]
    public uint E0;
}
