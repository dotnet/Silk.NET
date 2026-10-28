// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkIndirectCommandsLayoutTokenEXT")]
public unsafe partial struct IndirectCommandsLayoutTokenEXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.IndirectCommandsLayoutTokenEXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("type")]
    public IndirectCommandsTokenTypeEXT Type;

    [NativeName("data")]
    public IndirectCommandsTokenDataEXT Data;

    [NativeName("offset")]
    public uint Offset;

    public IndirectCommandsLayoutTokenEXT() { }
}
