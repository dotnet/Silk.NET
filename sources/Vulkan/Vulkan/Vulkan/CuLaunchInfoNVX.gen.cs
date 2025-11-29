// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NameAffix("Suffix", "NVX", 0)]
[NativeName("VkCuLaunchInfoNVX")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct CuLaunchInfoNVX
{
    [NativeName("sType")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public StructureType SType;

    [NativeName("pNext")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public void* PNext;

    [NativeName("function")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public CuFunctionNVX Function;

    [NativeName("gridDimX")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint GridDimX;

    [NativeName("gridDimY")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint GridDimY;

    [NativeName("gridDimZ")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint GridDimZ;

    [NativeName("blockDimX")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint BlockDimX;

    [NativeName("blockDimY")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint BlockDimY;

    [NativeName("blockDimZ")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint BlockDimZ;

    [NativeName("sharedMemBytes")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public uint SharedMemBytes;

    [NativeName("paramCount")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public nuint ParamCount;

    [NativeName("pParams")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public void** PParams;

    [NativeName("extraCount")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public nuint ExtraCount;

    [NativeName("pExtras")]
    [SupportedApiProfile("vulkan", ["VK_NVX_binary_import"])]
    public void** PExtras;
}
