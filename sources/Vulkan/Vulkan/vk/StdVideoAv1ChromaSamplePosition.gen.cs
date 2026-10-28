// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1ChromaSamplePosition")]
public enum StdVideoAv1ChromaSamplePosition : uint
{
    [NativeName("STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_UNKNOWN")]
    Unknown = 0,

    [NativeName("STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_VERTICAL")]
    Vertical = 1,

    [NativeName("STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_COLOCATED")]
    Colocated = 2,

    [NativeName("STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_RESERVED")]
    Reserved = 3,
}
