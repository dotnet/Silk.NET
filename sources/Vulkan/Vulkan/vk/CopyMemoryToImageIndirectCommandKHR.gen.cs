// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkCopyMemoryToImageIndirectCommandKHR")]
public partial struct CopyMemoryToImageIndirectCommandKHR
{
    [NativeName("srcAddress")]
    public ulong SrcAddress;

    [NativeName("bufferRowLength")]
    public uint BufferRowLength;

    [NativeName("bufferImageHeight")]
    public uint BufferImageHeight;

    [NativeName("imageSubresource")]
    public ImageSubresourceLayers ImageSubresource;

    [NativeName("imageOffset")]
    public Offset3D ImageOffset;

    [NativeName("imageExtent")]
    public Extent3D ImageExtent;
}
