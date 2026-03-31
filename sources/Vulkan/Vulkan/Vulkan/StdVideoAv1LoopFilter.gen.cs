// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1LoopFilter")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoAv1LoopFilter
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1LoopFilterFlags Flags;

    [NativeName("loop_filter_level")]
    [NativeTypeName("uint8_t[4]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1LoopFilterLoopFilterLevel LoopFilterLevel;

    [NativeName("loop_filter_sharpness")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte LoopFilterSharpness;

    [NativeName("update_ref_delta")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte UpdateRefDelta;

    [NativeName("loop_filter_ref_deltas")]
    [NativeTypeName("int8_t[8]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1LoopFilterLoopFilterRefDeltas LoopFilterRefDeltas;

    [NativeName("update_mode_delta")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte UpdateModeDelta;

    [NativeName("loop_filter_mode_deltas")]
    [NativeTypeName("int8_t[2]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1LoopFilterLoopFilterModeDeltas LoopFilterModeDeltas;
}
