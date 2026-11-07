// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1ColorConfig")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoAv1ColorConfig
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1ColorConfigFlags Flags;

    [NativeName("BitDepth")]
    [SupportedApiProfile("vulkan")]
    public byte BitDepth;

    [NativeName("subsampling_x")]
    [SupportedApiProfile("vulkan")]
    public byte SubsamplingX;

    [NativeName("subsampling_y")]
    [SupportedApiProfile("vulkan")]
    public byte SubsamplingY;

    [NativeName("reserved1")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved1;

    [NativeName("color_primaries")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1ColorPrimaries ColorPrimaries;

    [NativeName("transfer_characteristics")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1TransferCharacteristics TransferCharacteristics;

    [NativeName("matrix_coefficients")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1MatrixCoefficients MatrixCoefficients;

    [NativeName("chroma_sample_position")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAv1ChromaSamplePosition ChromaSamplePosition;
}
