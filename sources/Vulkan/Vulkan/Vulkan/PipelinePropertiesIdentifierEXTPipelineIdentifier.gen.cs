// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("_pipelineIdentifier_e__FixedBuffer")]
[InlineArray(16)]
[SupportedApiProfile(
    "vulkan",
    ["VK_EXT_pipeline_properties"],
    ImpliesSets = [
        "VK_EXT_pipeline_properties+VK_KHR_get_physical_device_properties2",
        "VK_EXT_pipeline_properties+VK_VERSION_1_1",
    ]
)]
public partial struct PipelinePropertiesIdentifierEXTPipelineIdentifier
{
    [NativeName("e0")]
    [SupportedApiProfile("vulkan")]
    public byte E0;
}
