// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct StdVideoAV1LoopFilter
{
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1LoopFilterFlags Flags;

    [NativeTypeName("uint8_t[4]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1LoopFilterLoopFilterLevel LoopFilterLevel;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte LoopFilterSharpness;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte UpdateRefDelta;

    [NativeTypeName("int8_t[8]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1LoopFilterLoopFilterRefDeltas LoopFilterRefDeltas;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte UpdateModeDelta;

    [NativeTypeName("int8_t[2]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1LoopFilterLoopFilterModeDeltas LoopFilterModeDeltas;
}
