// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoVP9Profile")]
public enum StdVideoVp9Profile : uint
{
    [NativeName("STD_VIDEO_VP9_PROFILE_0")]
    Profile0 = 0,

    [NativeName("STD_VIDEO_VP9_PROFILE_1")]
    Profile1 = 1,

    [NativeName("STD_VIDEO_VP9_PROFILE_2")]
    Profile2 = 2,

    [NativeName("STD_VIDEO_VP9_PROFILE_3")]
    Profile3 = 3,
}
