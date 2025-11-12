// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct StdVideoH265ScalingLists
{
    [NativeTypeName("uint8_t[6][16]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ScalingListsScalingList4X4 ScalingList4X4;

    [NativeTypeName("uint8_t[6][64]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ScalingListsScalingList8X8 ScalingList8X8;

    [NativeTypeName("uint8_t[6][64]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ScalingListsScalingList16X16 ScalingList16X16;

    [NativeTypeName("uint8_t[2][64]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ScalingListsScalingList32X32 ScalingList32X32;

    [NativeTypeName("uint8_t[6]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ScalingListsScalingListDCCoef16X16 ScalingListDCCoef16X16;

    [NativeTypeName("uint8_t[2]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH265ScalingListsScalingListDCCoef32X32 ScalingListDCCoef32X32;
}
