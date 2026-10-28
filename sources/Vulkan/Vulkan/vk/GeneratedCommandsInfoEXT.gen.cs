// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkGeneratedCommandsInfoEXT")]
public unsafe partial struct GeneratedCommandsInfoEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.GeneratedCommandsInfoEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("shaderStages")]
    public ShaderStageFlags ShaderStages;

    [NativeName("indirectExecutionSet")]
    public IndirectExecutionSetHandleEXT IndirectExecutionSet;

    [NativeName("indirectCommandsLayout")]
    public IndirectCommandsLayoutHandleEXT IndirectCommandsLayout;

    [NativeName("indirectAddress")]
    public ulong IndirectAddress;

    [NativeName("indirectAddressSize")]
    public ulong IndirectAddressSize;

    [NativeName("preprocessAddress")]
    public ulong PreprocessAddress;

    [NativeName("preprocessSize")]
    public ulong PreprocessSize;

    [NativeName("maxSequenceCount")]
    public uint MaxSequenceCount;

    [NativeName("sequenceCountAddress")]
    public ulong SequenceCountAddress;

    [NativeName("maxDrawCount")]
    public uint MaxDrawCount;

    public GeneratedCommandsInfoEXT() { }
}
