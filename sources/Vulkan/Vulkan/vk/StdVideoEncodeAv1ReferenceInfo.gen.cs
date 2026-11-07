// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoEncodeAV1ReferenceInfo")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoEncodeAv1ReferenceInfo
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeAv1ReferenceInfoFlags Flags;

    [NativeName("RefFrameId")]
    [SupportedApiProfile("vulkan")]
    public uint RefFrameId;

    [NativeName("frame_type")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1FrameType FrameType;

    [NativeName("OrderHint")]
    [SupportedApiProfile("vulkan")]
    public byte OrderHint;

    [NativeName("reserved1")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeAv1ReferenceInfoReserved1 Reserved1;

    [NativeName("pExtensionHeader")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeAv1ExtensionHeader* PExtensionHeader;
}
