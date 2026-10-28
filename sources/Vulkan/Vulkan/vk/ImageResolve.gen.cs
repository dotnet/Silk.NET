// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImageResolve")]
public partial struct ImageResolve
{
    [NativeName("srcSubresource")]
    public ImageSubresourceLayers SrcSubresource;

    [NativeName("srcOffset")]
    public Offset3D SrcOffset;

    [NativeName("dstSubresource")]
    public ImageSubresourceLayers DstSubresource;

    [NativeName("dstOffset")]
    public Offset3D DstOffset;

    [NativeName("extent")]
    public Extent3D Extent;
}
