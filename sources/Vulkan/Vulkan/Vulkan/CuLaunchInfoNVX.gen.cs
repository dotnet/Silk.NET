// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct CuLaunchInfoNVX
{
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public StructureType SType;

    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public void* PNext;

    [NativeTypeName("VkCuFunctionNVX")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public CuFunctionNVXTHandle Function;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint GridDimX;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint GridDimY;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint GridDimZ;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint BlockDimX;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint BlockDimY;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint BlockDimZ;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint SharedMemBytes;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public nuint ParamCount;

    [NativeTypeName("const void *const *")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public void** PParams;

    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public nuint ExtraCount;

    [NativeTypeName("const void *const *")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public void** PExtras;
}
