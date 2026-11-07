// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAccelerationStructureGeometryKHR")]
public unsafe partial struct AccelerationStructureGeometryKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.AccelerationStructureGeometryKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("geometryType")]
    public GeometryTypeKHR GeometryType;

    [NativeName("geometry")]
    public AccelerationStructureGeometryDataKHR Geometry;

    [NativeName("flags")]
    public GeometryFlagsKHR Flags;

    public AccelerationStructureGeometryKHR() { }
}
