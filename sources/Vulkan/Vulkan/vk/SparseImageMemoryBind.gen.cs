// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSparseImageMemoryBind")]
public unsafe partial struct SparseImageMemoryBind
{
    [NativeName("subresource")]
    public ImageSubresource Subresource;

    [NativeName("offset")]
    public Offset3D Offset;

    [NativeName("extent")]
    public Extent3D Extent;

    [NativeName("memory")]
    public DeviceMemoryHandle Memory;

    [NativeName("memoryOffset")]
    public ulong MemoryOffset;

    [NativeName("flags")]
    public SparseMemoryBindFlags Flags;
}
