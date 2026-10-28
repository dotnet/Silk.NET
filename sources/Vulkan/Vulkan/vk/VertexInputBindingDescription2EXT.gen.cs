// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVertexInputBindingDescription2EXT")]
public unsafe partial struct VertexInputBindingDescription2EXT
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VertexInputBindingDescription2EXT;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("binding")]
    public uint Binding;

    [NativeName("stride")]
    public uint Stride;

    [NativeName("inputRate")]
    public VertexInputRate InputRate;

    [NativeName("divisor")]
    public uint Divisor;

    public VertexInputBindingDescription2EXT() { }
}
