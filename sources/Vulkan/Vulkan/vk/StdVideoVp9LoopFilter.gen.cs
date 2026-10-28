// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoVP9LoopFilter")]
public partial struct StdVideoVp9LoopFilter
{
    [NativeName("flags")]
    public StdVideoVp9LoopFilterFlags Flags;

    [NativeName("loop_filter_level")]
    public byte LoopFilterLevel;

    [NativeName("loop_filter_sharpness")]
    public byte LoopFilterSharpness;

    [NativeName("update_ref_delta")]
    public byte UpdateRefDelta;

    [NativeName("loop_filter_ref_deltas")]
    public StdVideoVp9LoopFilterLoopFilterRefDeltas LoopFilterRefDeltas;

    [NativeName("update_mode_delta")]
    public byte UpdateModeDelta;

    [NativeName("loop_filter_mode_deltas")]
    public StdVideoVp9LoopFilterLoopFilterModeDeltas LoopFilterModeDeltas;
}
