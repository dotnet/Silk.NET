// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoDecodeAV1ReferenceInfo")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoDecodeAV1ReferenceInfo
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeAV1ReferenceInfoFlags Flags;

    [NativeName("frame_type")]
    [SupportedApiProfile("vulkan")]
    public byte FrameType;

    [NativeName("RefFrameSignBias")]
    [SupportedApiProfile("vulkan")]
    public byte RefFrameSignBias;

    [NativeName("OrderHint")]
    [SupportedApiProfile("vulkan")]
    public byte OrderHint;

    [NativeName("SavedOrderHints")]
    [SupportedApiProfile("vulkan")]
    public StdVideoDecodeAV1ReferenceInfoSavedOrderHints SavedOrderHints;
}
