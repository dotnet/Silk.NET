// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameSuffix("NV", 0)]
[NativeName("VkExternalComputeQueueDataParamsNV")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct ExternalComputeQueueDataParamsNV
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    public void* PNext;

    [NativeName("deviceIndex")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    public uint DeviceIndex;
}
