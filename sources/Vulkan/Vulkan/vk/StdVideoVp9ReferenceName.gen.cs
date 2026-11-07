// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoVP9ReferenceName")]
public enum StdVideoVp9ReferenceName : uint
{
    [NativeName("STD_VIDEO_VP9_REFERENCE_NAME_INTRA_FRAME")]
    IntraFrame = 0,

    [NativeName("STD_VIDEO_VP9_REFERENCE_NAME_LAST_FRAME")]
    LastFrame = 1,

    [NativeName("STD_VIDEO_VP9_REFERENCE_NAME_GOLDEN_FRAME")]
    GoldenFrame = 2,

    [NativeName("STD_VIDEO_VP9_REFERENCE_NAME_ALTREF_FRAME")]
    AltrefFrame = 3,
}
