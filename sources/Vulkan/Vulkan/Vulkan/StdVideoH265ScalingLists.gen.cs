// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH265ScalingLists")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoH265ScalingLists
{
    [NativeName("ScalingList4x4")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ScalingListsScalingList4X4 ScalingList4X4;

    [NativeName("ScalingList8x8")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ScalingListsScalingList8X8 ScalingList8X8;

    [NativeName("ScalingList16x16")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ScalingListsScalingList16X16 ScalingList16X16;

    [NativeName("ScalingList32x32")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ScalingListsScalingList32X32 ScalingList32X32;

    [NativeName("ScalingListDCCoef16x16")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ScalingListsScalingListDcCoef16X16 ScalingListDcCoef16X16;

    [NativeName("ScalingListDCCoef32x32")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ScalingListsScalingListDcCoef32X32 ScalingListDcCoef32X32;
}
