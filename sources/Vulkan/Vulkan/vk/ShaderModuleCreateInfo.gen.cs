// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkShaderModuleCreateInfo")]
public unsafe partial struct ShaderModuleCreateInfo
{
    [NativeName("sType")]
    public StructureType SType = StructureType.ShaderModuleCreateInfo;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("flags")]
    public ShaderModuleCreateFlags Flags;

    [NativeName("codeSize")]
    public nuint CodeSize;

    [NativeName("pCode")]
    public uint* PCode;

    public ShaderModuleCreateInfo() { }
}
