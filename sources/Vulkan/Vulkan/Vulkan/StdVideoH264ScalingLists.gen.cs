// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoH264ScalingLists")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoH264ScalingLists
{
    [NativeName("scaling_list_present_mask")]
    [SupportedApiProfile("vulkan")]
    public ushort ScalingListPresentMask;

    [NativeName("use_default_scaling_matrix_mask")]
    [SupportedApiProfile("vulkan")]
    public ushort UseDefaultScalingMatrixMask;

    [NativeName("ScalingList4x4")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264ScalingListsScalingList4X4 ScalingList4X4;

    [NativeName("ScalingList8x8")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264ScalingListsScalingList8X8 ScalingList8X8;
}
