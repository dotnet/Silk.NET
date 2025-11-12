// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoH265VideoParameterSet
{
    [SupportedApiProfile("vulkan")]
    public StdVideoH265VpsFlags Flags;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte VpsVideoParameterSetId;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte VpsMaxSubLayersMinus1;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved1;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved2;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint VpsNumUnitsInTick;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint VpsTimeScale;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint VpsNumTicksPocDiffOneMinus1;

    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint Reserved3;

    [NativeTypeName("const StdVideoH265DecPicBufMgr *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265DecPicBufMgr* PDecPicBufMgr;

    [NativeTypeName("const StdVideoH265HrdParameters *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265HrdParameters* PHrdParameters;

    [NativeTypeName("const StdVideoH265ProfileTierLevel *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ProfileTierLevel* PProfileTierLevel;
}
