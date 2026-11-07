// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264PictureType")]
public enum StdVideoH264PictureType : uint
{
    [NativeName("STD_VIDEO_H264_PICTURE_TYPE_P")]
    P = 0,

    [NativeName("STD_VIDEO_H264_PICTURE_TYPE_B")]
    B = 1,

    [NativeName("STD_VIDEO_H264_PICTURE_TYPE_I")]
    I = 2,

    [NativeName("STD_VIDEO_H264_PICTURE_TYPE_IDR")]
    Idr = 5,
}
