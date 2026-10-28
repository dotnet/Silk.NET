// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH265VideoParameterSet")]
public unsafe partial struct StdVideoH265VideoParameterSet
{
    [NativeName("flags")]
    public StdVideoH265VpsFlags Flags;

    [NativeName("vps_video_parameter_set_id")]
    public byte VpsVideoParameterSetId;

    [NativeName("vps_max_sub_layers_minus1")]
    public byte VpsMaxSubLayersMinus1;

    [NativeName("reserved1")]
    public byte Reserved1;

    [NativeName("reserved2")]
    public byte Reserved2;

    [NativeName("vps_num_units_in_tick")]
    public uint VpsNumUnitsInTick;

    [NativeName("vps_time_scale")]
    public uint VpsTimeScale;

    [NativeName("vps_num_ticks_poc_diff_one_minus1")]
    public uint VpsNumTicksPocDiffOneMinus1;

    [NativeName("reserved3")]
    public uint Reserved3;

    [NativeName("pDecPicBufMgr")]
    public StdVideoH265DecPicBufMgr* PDecPicBufMgr;

    [NativeName("pHrdParameters")]
    public StdVideoH265HrdParameters* PHrdParameters;

    [NativeName("pProfileTierLevel")]
    public StdVideoH265ProfileTierLevel* PProfileTierLevel;
}
