// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeH265PictureInfoKHR")]
public unsafe partial struct VideoEncodeH265PictureInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeH265PictureInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("naluSliceSegmentEntryCount")]
    public uint NaluSliceSegmentEntryCount;

    [NativeName("pNaluSliceSegmentEntries")]
    public VideoEncodeH265NaluSliceSegmentInfoKHR* PNaluSliceSegmentEntries;

    [NativeName("pStdPictureInfo")]
    public StdVideoEncodeH265PictureInfo* PStdPictureInfo;

    public VideoEncodeH265PictureInfoKHR() { }
}
