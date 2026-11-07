// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSparseMemoryBind")]
public unsafe partial struct SparseMemoryBind
{
    [NativeName("resourceOffset")]
    public ulong ResourceOffset;

    [NativeName("size")]
    public ulong Size;

    [NativeName("memory")]
    public DeviceMemoryHandle Memory;

    [NativeName("memoryOffset")]
    public ulong MemoryOffset;

    [NativeName("flags")]
    public SparseMemoryBindFlags Flags;
}
