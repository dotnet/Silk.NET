// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoEncodeAV1ReferenceInfo
{
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeAV1ReferenceInfoFlags Flags;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint RefFrameId;

    [SupportedApiProfile("vulkan")]
    public StdVideoAV1FrameType FrameType;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte OrderHint;

    [NativeTypeName("uint8_t[3]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeAV1ReferenceInfoReserved1 Reserved1;

    [NativeTypeName("const StdVideoEncodeAV1ExtensionHeader *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoEncodeAV1ExtensionHeader* PExtensionHeader;
}
