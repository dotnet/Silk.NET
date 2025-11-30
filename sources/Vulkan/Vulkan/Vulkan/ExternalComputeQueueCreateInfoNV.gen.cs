// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NV", 0)]
[NativeName("VkExternalComputeQueueCreateInfoNV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct ExternalComputeQueueCreateInfoNV
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    public void* PNext;

    [NativeName("preferredQueue")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    public QueueHandle PreferredQueue;
}
