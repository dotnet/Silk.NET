// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkGeneratedCommandsMemoryRequirementsInfoEXT")]
public unsafe partial struct GeneratedCommandsMemoryRequirementsInfoEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.GeneratedCommandsMemoryRequirementsInfoEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("indirectExecutionSet")]
    public IndirectExecutionSetHandleEXT IndirectExecutionSet;

    [NativeName("indirectCommandsLayout")]
    public IndirectCommandsLayoutHandleEXT IndirectCommandsLayout;

    [NativeName("maxSequenceCount")]
    public uint MaxSequenceCount;

    [NativeName("maxDrawCount")]
    public uint MaxDrawCount;

    public GeneratedCommandsMemoryRequirementsInfoEXT() { }
}
