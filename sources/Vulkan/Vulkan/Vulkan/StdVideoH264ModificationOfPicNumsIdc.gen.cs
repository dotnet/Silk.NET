// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264ModificationOfPicNumsIdc")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH264ModificationOfPicNumsIdc : uint
{
    [NativeName("STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_SHORT_TERM_SUBTRACT")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264ModificationOfPicNumsIdcShortTermSubtract = 0,

    [NativeName("STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_SHORT_TERM_ADD")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264ModificationOfPicNumsIdcShortTermAdd = 1,

    [NativeName("STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_LONG_TERM")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264ModificationOfPicNumsIdcLongTerm = 2,

    [NativeName("STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_END")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264ModificationOfPicNumsIdcEnd = 3,

    [NativeName("STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264ModificationOfPicNumsIdcInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264ModificationOfPicNumsIdcMaxEnum = 0x7FFFFFFF,
}
