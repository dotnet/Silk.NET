// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1TxMode")]
[SupportedApiProfile("vulkan")]
public enum StdVideoAV1TxMode : uint
{
    [NativeName("STD_VIDEO_AV1_TX_MODE_ONLY_4X4")]
    [SupportedApiProfile("vulkan")]
    Only4X4 = 0,

    [NativeName("STD_VIDEO_AV1_TX_MODE_LARGEST")]
    [SupportedApiProfile("vulkan")]
    Largest = 1,

    [NativeName("STD_VIDEO_AV1_TX_MODE_SELECT")]
    [SupportedApiProfile("vulkan")]
    Select = 2,
}
