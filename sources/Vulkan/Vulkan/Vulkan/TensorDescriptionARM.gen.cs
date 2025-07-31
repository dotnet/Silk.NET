// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct TensorDescriptionARM
{
    [SupportedApiProfile("vulkan")]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan")]
    public void* PNext;

    [SupportedApiProfile("vulkan")]
    public TensorTilingARM Tiling;

    [SupportedApiProfile("vulkan")]
    public Format Format;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint DimensionCount;

    [NativeTypeName("const int64_t *")]
    [SupportedApiProfile("vulkan")]
    public long* PDimensions;

    [NativeTypeName("const int64_t *")]
    [SupportedApiProfile("vulkan")]
    public long* PStrides;

    [NativeTypeName("VkTensorUsageFlagsARM")]
    [SupportedApiProfile("vulkan")]
    public ulong Usage;
}
