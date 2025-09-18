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
public unsafe partial struct BindDataGraphPipelineSessionMemoryInfoARM
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [NativeTypeName("VkDataGraphPipelineSessionARM")]
    [SupportedApiProfile("vulkan")]
    public DataGraphPipelineSessionARMHandle Session;

    [SupportedApiProfile("vulkan")]
    public DataGraphPipelineSessionBindPointARM BindPoint;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint ObjectIndex;

    [NativeTypeName("VkDeviceMemory")]
    [SupportedApiProfile("vulkan")]
    public DeviceMemoryHandle Memory;

    [NativeTypeName("VkDeviceSize")]
    [SupportedApiProfile("vulkan")]
    public ulong MemoryOffset;
}
