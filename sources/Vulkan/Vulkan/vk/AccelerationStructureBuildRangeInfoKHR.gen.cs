// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAccelerationStructureBuildRangeInfoKHR")]
public partial struct AccelerationStructureBuildRangeInfoKHR
{
    [NativeName("primitiveCount")]
    public uint PrimitiveCount;

    [NativeName("primitiveOffset")]
    public uint PrimitiveOffset;

    [NativeName("firstVertex")]
    public uint FirstVertex;

    [NativeName("transformOffset")]
    public uint TransformOffset;
}
