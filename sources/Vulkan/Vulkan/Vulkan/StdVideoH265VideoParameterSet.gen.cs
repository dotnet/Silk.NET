// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH265VideoParameterSet")]
[SupportedApiProfile("vulkan")]
public unsafe partial struct StdVideoH265VideoParameterSet
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265VpsFlags Flags;

    [NativeName("vps_video_parameter_set_id")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte VpsVideoParameterSetId;

    [NativeName("vps_max_sub_layers_minus1")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte VpsMaxSubLayersMinus1;

    [NativeName("reserved1")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved1;

    [NativeName("reserved2")]
    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved2;

    [NativeName("vps_num_units_in_tick")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint VpsNumUnitsInTick;

    [NativeName("vps_time_scale")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint VpsTimeScale;

    [NativeName("vps_num_ticks_poc_diff_one_minus1")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint VpsNumTicksPocDiffOneMinus1;

    [NativeName("reserved3")]
    [NativeTypeName("uint32_t")]
    [SupportedApiProfile("vulkan")]
    public uint Reserved3;

    [NativeName("pDecPicBufMgr")]
    [NativeTypeName("const StdVideoH265DecPicBufMgr *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265DecPicBufMgr* PDecPicBufMgr;

    [NativeName("pHrdParameters")]
    [NativeTypeName("const StdVideoH265HrdParameters *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265HrdParameters* PHrdParameters;

    [NativeName("pProfileTierLevel")]
    [NativeTypeName("const StdVideoH265ProfileTierLevel *")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ProfileTierLevel* PProfileTierLevel;
}
