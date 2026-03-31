// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1TxMode")]
[NativeTypeName("unsigned int")]
[SupportedApiProfile("vulkan")]
public enum StdVideoAv1TxMode : uint
{
    [NativeName("STD_VIDEO_AV1_TX_MODE_ONLY_4X4")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TxModeOnly4x4 = 0,

    [NativeName("STD_VIDEO_AV1_TX_MODE_LARGEST")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TxModeLargest = 1,

    [NativeName("STD_VIDEO_AV1_TX_MODE_SELECT")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TxModeSelect = 2,

    [NativeName("STD_VIDEO_AV1_TX_MODE_INVALID")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TxModeInvalid = 0x7FFFFFFF,

    [NativeName("STD_VIDEO_AV1_TX_MODE_MAX_ENUM")]
    [SupportedApiProfile("vulkan")]
    StdVideoAv1TxModeMaxEnum = 0x7FFFFFFF,
}
