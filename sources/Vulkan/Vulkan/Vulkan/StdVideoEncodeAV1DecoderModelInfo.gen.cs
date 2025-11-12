// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct StdVideoEncodeAV1DecoderModelInfo
{
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte BufferDelayLengthMinus1;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte BufferRemovalTimeLengthMinus1;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte FramePresentationTimeLengthMinus1;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved1;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint NumUnitsInDecodingTick;
}
