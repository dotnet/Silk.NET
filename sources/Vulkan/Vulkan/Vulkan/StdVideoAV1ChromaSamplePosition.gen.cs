// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1ChromaSamplePosition")]
[SupportedApiProfile("vulkan")]
public enum StdVideoAV1ChromaSamplePosition : uint
{
    [NativeName("STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_UNKNOWN")]
    [SupportedApiProfile("vulkan")]
    Unknown = 0,

    [NativeName("STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_VERTICAL")]
    [SupportedApiProfile("vulkan")]
    Vertical = 1,

    [NativeName("STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_COLOCATED")]
    [SupportedApiProfile("vulkan")]
    Colocated = 2,

    [NativeName("STD_VIDEO_AV1_CHROMA_SAMPLE_POSITION_RESERVED")]
    [SupportedApiProfile("vulkan")]
    Reserved = 3,
}
