// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264ChromaFormatIdc")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH264ChromaFormatIdc : uint
{
    [NativeName("STD_VIDEO_H264_CHROMA_FORMAT_IDC_MONOCHROME")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264ChromaFormatIdcMonochrome = 0,

    [NativeName("STD_VIDEO_H264_CHROMA_FORMAT_IDC_420")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264ChromaFormatIdc420 = 1,

    [NativeName("STD_VIDEO_H264_CHROMA_FORMAT_IDC_422")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264ChromaFormatIdc422 = 2,

    [NativeName("STD_VIDEO_H264_CHROMA_FORMAT_IDC_444")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264ChromaFormatIdc444 = 3,

    [NativeName("STD_VIDEO_H264_CHROMA_FORMAT_IDC_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264ChromaFormatIdcInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_H264_CHROMA_FORMAT_IDC_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264ChromaFormatIdcMaxEnum = 0x7FFFFFFF,
}
