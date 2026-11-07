// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264ModificationOfPicNumsIdc")]
public enum StdVideoH264ModificationOfPicNumsIdc : uint
{
    [NativeName("STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_SHORT_TERM_SUBTRACT")]
    ShortTermSubtract = 0,

    [NativeName("STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_SHORT_TERM_ADD")]
    ShortTermAdd = 1,

    [NativeName("STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_LONG_TERM")]
    LongTerm = 2,

    [NativeName("STD_VIDEO_H264_MODIFICATION_OF_PIC_NUMS_IDC_END")]
    End = 3,
}
