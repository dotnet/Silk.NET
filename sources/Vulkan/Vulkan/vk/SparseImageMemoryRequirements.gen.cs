// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkSparseImageMemoryRequirements")]
public partial struct SparseImageMemoryRequirements
{
    [NativeName("formatProperties")]
    public SparseImageFormatProperties FormatProperties;

    [NativeName("imageMipTailFirstLod")]
    public uint ImageMipTailFirstLod;

    [NativeName("imageMipTailSize")]
    public ulong ImageMipTailSize;

    [NativeName("imageMipTailOffset")]
    public ulong ImageMipTailOffset;

    [NativeName("imageMipTailStride")]
    public ulong ImageMipTailStride;
}
