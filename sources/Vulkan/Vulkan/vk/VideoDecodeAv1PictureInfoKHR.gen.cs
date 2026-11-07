// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoDecodeAV1PictureInfoKHR")]
public unsafe partial struct VideoDecodeAv1PictureInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoDecodeAv1PictureInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("pStdPictureInfo")]
    public StdVideoDecodeAv1PictureInfo* PStdPictureInfo;

    [NativeName("referenceNameSlotIndices")]
    public VideoDecodeAv1PictureInfoKHRReferenceNameSlotIndices ReferenceNameSlotIndices;

    [NativeName("frameHeaderOffset")]
    public uint FrameHeaderOffset;

    [NativeName("tileCount")]
    public uint TileCount;

    [NativeName("pTileOffsets")]
    public uint* PTileOffsets;

    [NativeName("pTileSizes")]
    public uint* PTileSizes;

    public VideoDecodeAv1PictureInfoKHR() { }
}
