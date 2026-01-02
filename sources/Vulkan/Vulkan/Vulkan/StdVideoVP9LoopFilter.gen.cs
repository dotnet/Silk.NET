// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct StdVideoVP9LoopFilter
{
    [SupportedApiProfile("vulkan")]
    public StdVideoVP9LoopFilterFlags Flags;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte LoopFilterLevel;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte LoopFilterSharpness;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte UpdateRefDelta;

    [NativeTypeName("int8_t[4]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoVP9LoopFilterLoopFilterRefDeltas LoopFilterRefDeltas;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte UpdateModeDelta;

    [NativeTypeName("int8_t[2]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoVP9LoopFilterLoopFilterModeDeltas LoopFilterModeDeltas;
}
