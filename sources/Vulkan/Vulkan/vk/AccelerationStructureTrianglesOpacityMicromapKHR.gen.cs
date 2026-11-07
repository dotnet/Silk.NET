// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAccelerationStructureTrianglesOpacityMicromapKHR")]
public unsafe partial struct AccelerationStructureTrianglesOpacityMicromapKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.AccelerationStructureTrianglesOpacityMicromapKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("indexType")]
    public IndexType IndexType;

    [NativeName("indexBuffer")]
    public ulong IndexBuffer;

    [NativeName("indexStride")]
    public ulong IndexStride;

    [NativeName("baseTriangle")]
    public uint BaseTriangle;

    [NativeName("micromap")]
    public AccelerationStructureHandleKHR Micromap;

    public AccelerationStructureTrianglesOpacityMicromapKHR() { }
}
