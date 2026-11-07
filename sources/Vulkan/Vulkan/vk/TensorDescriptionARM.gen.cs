// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkTensorDescriptionARM")]
public unsafe partial struct TensorDescriptionARM
{
    [NativeName("sType")]
    public StructureType SType = StructureType.TensorDescriptionARM;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("tiling")]
    public TensorTilingARM Tiling;

    [NativeName("format")]
    public Format Format;

    [NativeName("dimensionCount")]
    public uint DimensionCount;

    [NativeName("pDimensions")]
    public long* PDimensions;

    [NativeName("pStrides")]
    public long* PStrides;

    [NativeName("usage")]
    public TensorUsageFlagsARM Usage;

    public TensorDescriptionARM() { }
}
