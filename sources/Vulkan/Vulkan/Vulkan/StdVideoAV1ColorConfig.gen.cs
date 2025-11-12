// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2023 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct StdVideoAV1ColorConfig
{
    [SupportedApiProfile("vulkan")]
    public StdVideoAV1ColorConfigFlags Flags;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte BitDepth;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SubsamplingX;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte SubsamplingY;

    [NativeTypeName("uint8_t")]
    [SupportedApiProfile("vulkan")]
    public byte Reserved1;

    [SupportedApiProfile("vulkan")]
    public StdVideoAV1ColorPrimaries ColorPrimaries;

    [SupportedApiProfile("vulkan")]
    public StdVideoAV1TransferCharacteristics TransferCharacteristics;

    [SupportedApiProfile("vulkan")]
    public StdVideoAV1MatrixCoefficients MatrixCoefficients;

    [SupportedApiProfile("vulkan")]
    public StdVideoAV1ChromaSamplePosition ChromaSamplePosition;
}
