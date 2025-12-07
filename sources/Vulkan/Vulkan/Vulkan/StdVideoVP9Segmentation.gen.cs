// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[SupportedApiProfile("vulkan")]
public partial struct StdVideoVP9Segmentation
{
    [SupportedApiProfile("vulkan")]
    public StdVideoVP9SegmentationFlags Flags;

    [NativeTypeName("uint8_t[7]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoVP9SegmentationSegmentationTreeProbs SegmentationTreeProbs;

    [NativeTypeName("uint8_t[3]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoVP9SegmentationSegmentationPredProb SegmentationPredProb;

    [NativeTypeName("uint8_t[8]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoVP9SegmentationFeatureEnabled FeatureEnabled;

    [NativeTypeName("int16_t[8][4]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoVP9SegmentationFeatureData FeatureData;
}
