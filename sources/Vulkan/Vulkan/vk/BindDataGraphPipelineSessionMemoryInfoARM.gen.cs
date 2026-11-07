// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkBindDataGraphPipelineSessionMemoryInfoARM")]
public unsafe partial struct BindDataGraphPipelineSessionMemoryInfoARM
{
    [NativeName("sType")]
    public StructureType SType = StructureType.BindDataGraphPipelineSessionMemoryInfoARM;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("session")]
    public DataGraphPipelineSessionHandleARM Session;

    [NativeName("bindPoint")]
    public DataGraphPipelineSessionBindPointARM BindPoint;

    [NativeName("objectIndex")]
    public uint ObjectIndex;

    [NativeName("memory")]
    public DeviceMemoryHandle Memory;

    [NativeName("memoryOffset")]
    public ulong MemoryOffset;

    public BindDataGraphPipelineSessionMemoryInfoARM() { }
}
