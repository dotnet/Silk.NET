// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH265PictureType")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoH265PictureType : uint
{
    [NativeName("STD_VIDEO_H265_PICTURE_TYPE_P")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265PictureTypeP = 0,

    [NativeName("STD_VIDEO_H265_PICTURE_TYPE_B")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265PictureTypeB = 1,

    [NativeName("STD_VIDEO_H265_PICTURE_TYPE_I")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265PictureTypeI = 2,

    [NativeName("STD_VIDEO_H265_PICTURE_TYPE_IDR")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265PictureTypeIdr = 3,

    [NativeName("STD_VIDEO_H265_PICTURE_TYPE_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265PictureTypeInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_H265_PICTURE_TYPE_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoH265PictureTypeMaxEnum = 0x7FFFFFFF,
}
