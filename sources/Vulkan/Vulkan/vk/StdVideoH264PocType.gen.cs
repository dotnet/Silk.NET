// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264PocType")]
public enum StdVideoH264PocType : uint
{
    [NativeName("STD_VIDEO_H264_POC_TYPE_0")]
    Type0 = 0,

    [NativeName("STD_VIDEO_H264_POC_TYPE_1")]
    Type1 = 1,

    [NativeName("STD_VIDEO_H264_POC_TYPE_2")]
    Type2 = 2,
}
