// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("PFN_vkLayerCreateDevice")]
[SupportedApiProfile("vulkan")]
public unsafe delegate Result LayerCreateDeviceDelegate(
    InstanceHandle arg0,
    PhysicalDeviceHandle arg1,
    DeviceCreateInfo* arg2,
    AllocationCallbacks* arg3,
    DeviceHandle* arg4,
    LayerCreateDeviceP5 arg5,
    LayerCreateDeviceP6* arg6
);
