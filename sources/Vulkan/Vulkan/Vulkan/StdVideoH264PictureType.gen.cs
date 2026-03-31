// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264PictureType")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH264PictureType : uint
{
    [NativeName("STD_VIDEO_H264_PICTURE_TYPE_P")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264PictureTypeP = 0,

    [NativeName("STD_VIDEO_H264_PICTURE_TYPE_B")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264PictureTypeB = 1,

    [NativeName("STD_VIDEO_H264_PICTURE_TYPE_I")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264PictureTypeI = 2,

    [NativeName("STD_VIDEO_H264_PICTURE_TYPE_IDR")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264PictureTypeIdr = 5,

    [NativeName("STD_VIDEO_H264_PICTURE_TYPE_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264PictureTypeInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_H264_PICTURE_TYPE_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoH264PictureTypeMaxEnum = 0x7FFFFFFF,
}
