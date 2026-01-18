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
    [SupportedApiProfile("vulkan")]
    public byte VpsVideoParameterSetId;

    [NativeName("vps_max_sub_layers_minus1")]
    [SupportedApiProfile("vulkan")]
    public byte VpsMaxSubLayersMinus1;

    [NativeName("reserved1")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved1;

    [NativeName("reserved2")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved2;

    [NativeName("vps_num_units_in_tick")]
    [SupportedApiProfile("vulkan")]
    public uint VpsNumUnitsInTick;

    [NativeName("vps_time_scale")]
    [SupportedApiProfile("vulkan")]
    public uint VpsTimeScale;

    [NativeName("vps_num_ticks_poc_diff_one_minus1")]
    [SupportedApiProfile("vulkan")]
    public uint VpsNumTicksPocDiffOneMinus1;

    [NativeName("reserved3")]
    [SupportedApiProfile("vulkan")]
    public uint Reserved3;

    [NativeName("pDecPicBufMgr")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265DecPicBufMgr* PDecPicBufMgr;

    [NativeName("pHrdParameters")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265HrdParameters* PHrdParameters;

    [NativeName("pProfileTierLevel")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ProfileTierLevel* PProfileTierLevel;
}
