// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkPhysicalDevicePipelineBinaryPropertiesKHR")]
public unsafe partial struct PhysicalDevicePipelineBinaryPropertiesKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.PhysicalDevicePipelineBinaryPropertiesKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("pipelineBinaryInternalCache")]
    public MaybeBool<uint> PipelineBinaryInternalCache;

    [NativeName("pipelineBinaryInternalCacheControl")]
    public MaybeBool<uint> PipelineBinaryInternalCacheControl;

    [NativeName("pipelineBinaryPrefersInternalCache")]
    public MaybeBool<uint> PipelineBinaryPrefersInternalCache;

    [NativeName("pipelineBinaryPrecompiledInternalCache")]
    public MaybeBool<uint> PipelineBinaryPrecompiledInternalCache;

    [NativeName("pipelineBinaryCompressedData")]
    public MaybeBool<uint> PipelineBinaryCompressedData;

    public PhysicalDevicePipelineBinaryPropertiesKHR() { }
}
