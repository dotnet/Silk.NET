// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264ChromaFormatIdc")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH264ChromaFormatIdc : uint
{
    [NativeName("STD_VIDEO_H264_CHROMA_FORMAT_IDC_MONOCHROME")]
    [SupportedApiProfile("vulkan")]
    IdcMonochrome = 0,

    [NativeName("STD_VIDEO_H264_CHROMA_FORMAT_IDC_420")]
    [SupportedApiProfile("vulkan")]
    Idc420 = 1,

    [NativeName("STD_VIDEO_H264_CHROMA_FORMAT_IDC_422")]
    [SupportedApiProfile("vulkan")]
    Idc422 = 2,

    [NativeName("STD_VIDEO_H264_CHROMA_FORMAT_IDC_444")]
    [SupportedApiProfile("vulkan")]
    Idc444 = 3,
}
