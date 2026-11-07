// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkDecompressMemoryRegionNV")]
public partial struct DecompressMemoryRegionNV
{
    [NativeName("srcAddress")]
    public ulong SrcAddress;

    [NativeName("dstAddress")]
    public ulong DstAddress;

    [NativeName("compressedSize")]
    public ulong CompressedSize;

    [NativeName("decompressedSize")]
    public ulong DecompressedSize;

    [NativeName("decompressionMethod")]
    public MemoryDecompressionMethodFlagsEXT DecompressionMethod;
}
