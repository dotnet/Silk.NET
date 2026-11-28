// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("_layerDevice_e__Struct")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct LayerInstanceCreateInfoULayerDevice
{
    [NativeName("pfnLayerCreateDevice")]
    [SupportedApiProfile("vulkan")]
    public LayerCreateDevice PfnLayerCreateDevice;

    [NativeName("pfnLayerDestroyDevice")]
    [SupportedApiProfile("vulkan")]
    public LayerDestroyDevice PfnLayerDestroyDevice;
}
