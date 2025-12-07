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
public partial struct StdVideoAV1ColorConfig
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1ColorConfigFlags Flags;

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
    public StdVideoAV1ColorPrimaries ColorPrimaries;

    [NativeName("transfer_characteristics")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1TransferCharacteristics TransferCharacteristics;

    [NativeName("matrix_coefficients")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1MatrixCoefficients MatrixCoefficients;

    [NativeName("chroma_sample_position")]
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1ChromaSamplePosition ChromaSamplePosition;
}
