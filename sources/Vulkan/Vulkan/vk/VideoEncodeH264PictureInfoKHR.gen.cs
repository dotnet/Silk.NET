// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeH264PictureInfoKHR")]
public unsafe partial struct VideoEncodeH264PictureInfoKHR
{
    [NativeName("sType")]
    public StructureType SType = StructureType.VideoEncodeH264PictureInfoKHR;

    [NativeName("pNext")]
    public void* PNext;

    [NativeName("naluSliceEntryCount")]
    public uint NaluSliceEntryCount;

    [NativeName("pNaluSliceEntries")]
    public VideoEncodeH264NaluSliceInfoKHR* PNaluSliceEntries;

    [NativeName("pStdPictureInfo")]
    public StdVideoEncodeH264PictureInfo* PStdPictureInfo;

    [NativeName("generatePrefixNalu")]
    public MaybeBool<uint> GeneratePrefixNalu;

    public VideoEncodeH264PictureInfoKHR() { }
}
