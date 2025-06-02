// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct PhysicalDeviceExternalComputeQueuePropertiesNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    public StructureType SType;

    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    public void* PNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    public uint ExternalDataSize;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_external_compute_queue"])]
    public uint MaxExternalQueues;
}
