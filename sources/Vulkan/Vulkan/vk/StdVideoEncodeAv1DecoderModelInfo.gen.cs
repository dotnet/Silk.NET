// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoEncodeAV1DecoderModelInfo")]
public partial struct StdVideoEncodeAv1DecoderModelInfo
{
    [NativeName("buffer_delay_length_minus_1")]
    public byte BufferDelayLengthMinus1;

    [NativeName("buffer_removal_time_length_minus_1")]
    public byte BufferRemovalTimeLengthMinus1;

    [NativeName("frame_presentation_time_length_minus_1")]
    public byte FramePresentationTimeLengthMinus1;

    [NativeName("reserved1")]
    public byte Reserved1;

    [NativeName("num_units_in_decoding_tick")]
    public uint NumUnitsInDecodingTick;
}
