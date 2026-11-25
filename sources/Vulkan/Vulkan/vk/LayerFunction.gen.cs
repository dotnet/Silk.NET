// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkLayerFunction_")]
[SupportedApiProfile("vulkan")]
public enum LayerFunction : uint
{
    [NativeName("VK_LAYER_LINK_INFO")]
    [SupportedApiProfile("vulkan")]
    LayerLinkInfo = 0,

    [NativeName("VK_LOADER_DATA_CALLBACK")]
    [SupportedApiProfile("vulkan")]
    LoaderDataCallback = 1,

    [NativeName("VK_LOADER_LAYER_CREATE_DEVICE_CALLBACK")]
    [SupportedApiProfile("vulkan")]
    LoaderLayerCreateDeviceCallback = 2,

    [NativeName("VK_LOADER_FEATURES")]
    [SupportedApiProfile("vulkan")]
    LoaderFeatures = 3,
}
