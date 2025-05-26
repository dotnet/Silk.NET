// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct ConvertCooperativeVectorMatrixInfoNV
{
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public void* PNext;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public nuint SrcSize;

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public DeviceOrHostAddressConstKHR SrcData;

    [NativeTypeName("size_t *")]
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public nuint* PDstSize;

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public DeviceOrHostAddressKHR DstData;

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public ComponentTypeKHR SrcComponentType;

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public ComponentTypeKHR DstComponentType;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public uint NumRows;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public uint NumColumns;

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public CooperativeVectorMatrixLayoutNV SrcLayout;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public nuint SrcStride;

    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public CooperativeVectorMatrixLayoutNV DstLayout;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan", ["VK_NV_cooperative_vector"])]
    public nuint DstStride;
}
