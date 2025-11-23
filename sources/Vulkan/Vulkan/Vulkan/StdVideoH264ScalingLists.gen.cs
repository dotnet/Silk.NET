// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct StdVideoH264ScalingLists
{
    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort ScalingListPresentMask;

    [NativeTypeName("uint16_t")]
    [SupportedApiProfile("vulkan")]
    public ushort UseDefaultScalingMatrixMask;

    [NativeTypeName("uint8_t[6][16]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264ScalingListsScalingList4X4 ScalingList4X4;

    [NativeTypeName("uint8_t[6][64]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoH264ScalingListsScalingList8X8 ScalingList8X8;
}
