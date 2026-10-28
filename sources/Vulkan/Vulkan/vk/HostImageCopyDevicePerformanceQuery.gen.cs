// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkHostImageCopyDevicePerformanceQuery")]
public unsafe partial struct HostImageCopyDevicePerformanceQuery
{
    [NativeName("sType")]
    public StructureType SType = StructureType.HostImageCopyDevicePerformanceQuery;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("optimalDeviceAccess")]
    public MaybeBool<uint> OptimalDeviceAccess;

    [NativeName("identicalMemoryLayout")]
    public MaybeBool<uint> IdenticalMemoryLayout;

    public HostImageCopyDevicePerformanceQuery() { }
}
