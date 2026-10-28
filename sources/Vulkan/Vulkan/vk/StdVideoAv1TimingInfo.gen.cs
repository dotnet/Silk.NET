// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1TimingInfo")]
public partial struct StdVideoAv1TimingInfo
{
    [NativeName("flags")]
    public StdVideoAv1TimingInfoFlags Flags;

    [NativeName("num_units_in_display_tick")]
    public uint NumUnitsInDisplayTick;

    [NativeName("time_scale")]
    public uint TimeScale;

    [NativeName("num_ticks_per_picture_minus_1")]
    public uint NumTicksPerPictureMinus1;
}
