// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct TensorCopyARM
{
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public void* PNext;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public uint DimensionCount;

    [NativeTypeName("const uint64_t *")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public ulong* PSrcOffset;

    [NativeTypeName("const uint64_t *")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public ulong* PDstOffset;

    [NativeTypeName("const uint64_t *")]
    [SupportedApiProfile("vulkan", ["VK_ARM_tensors"], ImpliesSets = ["VK_VERSION_1_3"])]
    public ulong* PExtent;
}
