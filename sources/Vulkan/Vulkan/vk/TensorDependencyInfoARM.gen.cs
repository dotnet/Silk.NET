// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkTensorDependencyInfoARM")]
public unsafe partial struct TensorDependencyInfoARM
{
    [NativeName("sType")]
    public StructureType SType = StructureType.TensorDependencyInfoARM;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("tensorMemoryBarrierCount")]
    public uint TensorMemoryBarrierCount;

    [NativeName("pTensorMemoryBarriers")]
    public TensorMemoryBarrierARM* PTensorMemoryBarriers;

    public TensorDependencyInfoARM() { }
}
