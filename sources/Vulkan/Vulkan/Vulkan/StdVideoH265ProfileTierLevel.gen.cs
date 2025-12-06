// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH265ProfileTierLevel")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoH265ProfileTierLevel
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ProfileTierLevelFlags Flags;

    [NativeName("general_profile_idc")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ProfileIdc GeneralProfileIdc;

    [NativeName("general_level_idc")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265LevelIdc GeneralLevelIdc;
}
