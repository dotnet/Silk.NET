// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1Profile")]
public enum StdVideoAv1Profile : uint
{
    [NativeName("STD_VIDEO_AV1_PROFILE_MAIN")]
    Main = 0,

    [NativeName("STD_VIDEO_AV1_PROFILE_HIGH")]
    High = 1,

    [NativeName("STD_VIDEO_AV1_PROFILE_PROFESSIONAL")]
    Professional = 2,
}
