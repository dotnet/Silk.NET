// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct TensorCreateInfoARM
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkTensorCreateFlagsARM")]
    [SupportedApiProfile("vulkan")]
    public ulong Flags;

    [NativeTypeName("const VkTensorDescriptionARM *")]
    [SupportedApiProfile("vulkan")]
    public TensorDescriptionARM* PDescription;

    [SupportedApiProfile("vulkan")]
    public SharingMode SharingMode;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint QueueFamilyIndexCount;

    [NativeTypeName("const uint32_t *")]
    [SupportedApiProfile("vulkan")]
    public uint* PQueueFamilyIndices;
}
