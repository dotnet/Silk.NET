// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoAV1SequenceHeader
{
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1SequenceHeaderFlags Flags;

    [SupportedApiProfile("vulkan")]
    public StdVideoAV1Profile SeqProfile;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte FrameWidthBitsMinus1;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte FrameHeightBitsMinus1;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort MaxFrameWidthMinus1;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort MaxFrameHeightMinus1;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte DeltaFrameIdLengthMinus2;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte AdditionalFrameIdLengthMinus1;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte OrderHintBitsMinus1;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SeqForceIntegerMv;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SeqForceScreenContentTools;

    [NativeTypeName("uint8_t[5]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1SequenceHeaderReserved1 Reserved1;

    [NativeTypeName("const StdVideoAV1ColorConfig *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1ColorConfig* PColorConfig;

    [NativeTypeName("const StdVideoAV1TimingInfo *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1TimingInfo* PTimingInfo;
}
