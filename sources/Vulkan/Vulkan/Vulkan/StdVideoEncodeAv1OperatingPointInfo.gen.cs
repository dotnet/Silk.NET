// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoEncodeAV1OperatingPointInfo")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoEncodeAv1OperatingPointInfo
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeAv1OperatingPointInfoFlags Flags;

    [NativeName("operating_point_idc")]
    [SupportedApiProfile("vulkan")]
    public ushort OperatingPointIdc;

    [NativeName("seq_level_idx")]
    [SupportedApiProfile("vulkan")]
    public byte SeqLevelIdx;

    [NativeName("seq_tier")]
    [SupportedApiProfile("vulkan")]
    public byte SeqTier;

    [NativeName("decoder_buffer_delay")]
    [SupportedApiProfile("vulkan")]
    public uint DecoderBufferDelay;

    [NativeName("encoder_buffer_delay")]
    [SupportedApiProfile("vulkan")]
    public uint EncoderBufferDelay;

    [NativeName("initial_display_delay_minus_1")]
    [SupportedApiProfile("vulkan")]
    public byte InitialDisplayDelayMinus1;
}
