// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1SequenceHeader")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoAv1SequenceHeader
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1SequenceHeaderFlags Flags;

    [NativeName("seq_profile")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1Profile SeqProfile;

    [NativeName("frame_width_bits_minus_1")]
    [SupportedApiProfile("vulkan")]
    public byte FrameWidthBitsMinus1;

    [NativeName("frame_height_bits_minus_1")]
    [SupportedApiProfile("vulkan")]
    public byte FrameHeightBitsMinus1;

    [NativeName("max_frame_width_minus_1")]
    [SupportedApiProfile("vulkan")]
    public ushort MaxFrameWidthMinus1;

    [NativeName("max_frame_height_minus_1")]
    [SupportedApiProfile("vulkan")]
    public ushort MaxFrameHeightMinus1;

    [NativeName("delta_frame_id_length_minus_2")]
    [SupportedApiProfile("vulkan")]
    public byte DeltaFrameIdLengthMinus2;

    [NativeName("additional_frame_id_length_minus_1")]
    [SupportedApiProfile("vulkan")]
    public byte AdditionalFrameIdLengthMinus1;

    [NativeName("order_hint_bits_minus_1")]
    [SupportedApiProfile("vulkan")]
    public byte OrderHintBitsMinus1;

    [NativeName("seq_force_integer_mv")]
    [SupportedApiProfile("vulkan")]
    public byte SeqForceIntegerMv;

    [NativeName("seq_force_screen_content_tools")]
    [SupportedApiProfile("vulkan")]
    public byte SeqForceScreenContentTools;

    [NativeName("reserved1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1SequenceHeaderReserved1 Reserved1;

    [NativeName("pColorConfig")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1ColorConfig* PColorConfig;

    [NativeName("pTimingInfo")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1TimingInfo* PTimingInfo;
}
