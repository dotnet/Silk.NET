// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkNegotiateLayerStructType")]
[SupportedApiProfile("vulkan")]
public enum NegotiateLayerStructType : uint
{
    [NativeName("LAYER_NEGOTIATE_UNINTIALIZED")]
    [SupportedApiProfile("vulkan")]
    Unintialized = 0,

    [NativeName("LAYER_NEGOTIATE_INTERFACE_STRUCT")]
    [SupportedApiProfile("vulkan")]
    InterfaceStruct = 1,
}
