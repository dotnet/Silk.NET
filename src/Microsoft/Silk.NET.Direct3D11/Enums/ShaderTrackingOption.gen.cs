// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_SHADER_TRACKING_OPTION")]
    public enum ShaderTrackingOption : int
    {
        [NativeName("Name", "D3D11_SHADER_TRACKING_OPTION_IGNORE")]
        ShaderTrackingOptionIgnore = 0x0,
        [NativeName("Name", "D3D11_SHADER_TRACKING_OPTION_TRACK_UNINITIALIZED")]
        ShaderTrackingOptionTrackUninitialized = 0x1,
        [NativeName("Name", "D3D11_SHADER_TRACKING_OPTION_TRACK_RAW")]
        ShaderTrackingOptionTrackRaw = 0x2,
        [NativeName("Name", "D3D11_SHADER_TRACKING_OPTION_TRACK_WAR")]
        ShaderTrackingOptionTrackWar = 0x4,
        [NativeName("Name", "D3D11_SHADER_TRACKING_OPTION_TRACK_WAW")]
        ShaderTrackingOptionTrackWaw = 0x8,
        [NativeName("Name", "D3D11_SHADER_TRACKING_OPTION_ALLOW_SAME")]
        ShaderTrackingOptionAllowSame = 0x10,
        [NativeName("Name", "D3D11_SHADER_TRACKING_OPTION_TRACK_ATOMIC_CONSISTENCY")]
        ShaderTrackingOptionTrackAtomicConsistency = 0x20,
        [NativeName("Name", "D3D11_SHADER_TRACKING_OPTION_TRACK_RAW_ACROSS_THREADGROUPS")]
        ShaderTrackingOptionTrackRawAcrossThreadgroups = 0x40,
        [NativeName("Name", "D3D11_SHADER_TRACKING_OPTION_TRACK_WAR_ACROSS_THREADGROUPS")]
        ShaderTrackingOptionTrackWarAcrossThreadgroups = 0x80,
        [NativeName("Name", "D3D11_SHADER_TRACKING_OPTION_TRACK_WAW_ACROSS_THREADGROUPS")]
        ShaderTrackingOptionTrackWawAcrossThreadgroups = 0x100,
        [NativeName("Name", "D3D11_SHADER_TRACKING_OPTION_TRACK_ATOMIC_CONSISTENCY_ACROSS_THREADGROUPS")]
        ShaderTrackingOptionTrackAtomicConsistencyAcrossThreadgroups = 0x200,
        [NativeName("Name", "D3D11_SHADER_TRACKING_OPTION_UAV_SPECIFIC_FLAGS")]
        ShaderTrackingOptionUavSpecificFlags = 0x3C0,
        [NativeName("Name", "D3D11_SHADER_TRACKING_OPTION_ALL_HAZARDS")]
        ShaderTrackingOptionAllHazards = 0x3EE,
        [NativeName("Name", "D3D11_SHADER_TRACKING_OPTION_ALL_HAZARDS_ALLOWING_SAME")]
        ShaderTrackingOptionAllHazardsAllowingSame = 0x3FE,
        [NativeName("Name", "D3D11_SHADER_TRACKING_OPTION_ALL_OPTIONS")]
        ShaderTrackingOptionAllOptions = 0x3FF,
    }
}
