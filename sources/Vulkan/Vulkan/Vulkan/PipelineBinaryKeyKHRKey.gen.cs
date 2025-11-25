// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("_key_e__FixedBuffer")]
[InlineArray(32)]
[SupportedApiProfile(
    "vulkan",
    ["VK_KHR_pipeline_binary"],
    ImpliesSets = [
        "VK_KHR_pipeline_binary+VK_KHR_maintenance5",
        "VK_KHR_pipeline_binary+VK_VERSION_1_4",
    ]
)]
public partial struct PipelineBinaryKeyKHRKey
{
    [NativeName("e0")]
    [SupportedApiProfile("vulkan")]
    public byte E0;
}
