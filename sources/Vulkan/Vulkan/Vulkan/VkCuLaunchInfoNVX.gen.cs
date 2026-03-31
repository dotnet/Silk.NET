// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCuLaunchInfoNVX")]
[NameAffix("Suffix", "KhronosVendor", "NVX")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct VkCuLaunchInfoNVX
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public VkStructureType SType;

    [NativeName("pNext")]
    [NativeTypeName("const void *")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public void* PNext;

    [NativeName("function")]
    [NativeTypeName("VkCuFunctionNVX")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public VkCuFunctionHandleNVX Function;

    [NativeName("gridDimX")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint GridDimX;

    [NativeName("gridDimY")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint GridDimY;

    [NativeName("gridDimZ")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint GridDimZ;

    [NativeName("blockDimX")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint BlockDimX;

    [NativeName("blockDimY")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint BlockDimY;

    [NativeName("blockDimZ")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint BlockDimZ;

    [NativeName("sharedMemBytes")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint SharedMemBytes;

    [NativeName("paramCount")]
    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public nuint ParamCount;

    [NativeName("pParams")]
    [NativeTypeName("const void *const *")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public void** PParams;

    [NativeName("extraCount")]
    [NativeTypeName("size_t")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public nuint ExtraCount;

    [NativeName("pExtras")]
    [NativeTypeName("const void *const *")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public void** PExtras;
}
