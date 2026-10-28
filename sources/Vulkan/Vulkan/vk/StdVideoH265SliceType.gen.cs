// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH265SliceType")]
public enum StdVideoH265SliceType : uint
{
    [NativeName("STD_VIDEO_H265_SLICE_TYPE_B")]
    B = 0,

    [NativeName("STD_VIDEO_H265_SLICE_TYPE_P")]
    P = 1,

    [NativeName("STD_VIDEO_H265_SLICE_TYPE_I")]
    I = 2,
}
