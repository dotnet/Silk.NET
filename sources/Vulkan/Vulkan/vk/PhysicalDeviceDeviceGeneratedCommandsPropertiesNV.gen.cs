// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDeviceDeviceGeneratedCommandsPropertiesNV")]
public unsafe partial struct PhysicalDeviceDeviceGeneratedCommandsPropertiesNV
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDeviceDeviceGeneratedCommandsPropertiesNV;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("maxGraphicsShaderGroupCount")]
    public uint MaxGraphicsShaderGroupCount;

    [NativeName("maxIndirectSequenceCount")]
    public uint MaxIndirectSequenceCount;

    [NativeName("maxIndirectCommandsTokenCount")]
    public uint MaxIndirectCommandsTokenCount;

    [NativeName("maxIndirectCommandsStreamCount")]
    public uint MaxIndirectCommandsStreamCount;

    [NativeName("maxIndirectCommandsTokenOffset")]
    public uint MaxIndirectCommandsTokenOffset;

    [NativeName("maxIndirectCommandsStreamStride")]
    public uint MaxIndirectCommandsStreamStride;

    [NativeName("minSequencesCountBufferOffsetAlignment")]
    public uint MinSequencesCountBufferOffsetAlignment;

    [NativeName("minSequencesIndexBufferOffsetAlignment")]
    public uint MinSequencesIndexBufferOffsetAlignment;

    [NativeName("minIndirectCommandsBufferOffsetAlignment")]
    public uint MinIndirectCommandsBufferOffsetAlignment;

    public PhysicalDeviceDeviceGeneratedCommandsPropertiesNV() { }
}
