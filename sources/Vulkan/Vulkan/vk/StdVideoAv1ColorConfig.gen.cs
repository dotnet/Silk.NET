// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1ColorConfig")]
public partial struct StdVideoAv1ColorConfig
{
    [NativeName("flags")]
    public StdVideoAv1ColorConfigFlags Flags;

    [NativeName("BitDepth")]
    public byte BitDepth;

    [NativeName("subsampling_x")]
    public byte SubsamplingX;

    [NativeName("subsampling_y")]
    public byte SubsamplingY;

    [NativeName("reserved1")]
    public byte Reserved1;

    [NativeName("color_primaries")]
    public StdVideoAv1ColorPrimaries ColorPrimaries;

    [NativeName("transfer_characteristics")]
    public StdVideoAv1TransferCharacteristics TransferCharacteristics;

    [NativeName("matrix_coefficients")]
    public StdVideoAv1MatrixCoefficients MatrixCoefficients;

    [NativeName("chroma_sample_position")]
    public StdVideoAv1ChromaSamplePosition ChromaSamplePosition;
}
