// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoDecodeVP9PictureInfoKHR")]
public unsafe partial struct VideoDecodeVp9PictureInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoDecodeVp9PictureInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("pStdPictureInfo")]
    public StdVideoDecodeVp9PictureInfo* PStdPictureInfo;

    [NativeName("referenceNameSlotIndices")]
    public VideoDecodeVp9PictureInfoKHRReferenceNameSlotIndices ReferenceNameSlotIndices;

    [NativeName("uncompressedHeaderOffset")]
    public uint UncompressedHeaderOffset;

    [NativeName("compressedHeaderOffset")]
    public uint CompressedHeaderOffset;

    [NativeName("tilesOffset")]
    public uint TilesOffset;

    public VideoDecodeVp9PictureInfoKHR() { }
}
