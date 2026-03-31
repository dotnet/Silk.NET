// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoVP9Segmentation")]
[SupportedApiProfile("vulkan")]
public partial struct StdVideoVp9Segmentation
{
    [NativeName("flags")]
    [SupportedApiProfile("vulkan")]
    public StdVideoVp9SegmentationFlags Flags;

    [NativeName("segmentation_tree_probs")]
    [NativeTypeName("uint8_t[7]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoVp9SegmentationSegmentationTreeProbs SegmentationTreeProbs;

    [NativeName("segmentation_pred_prob")]
    [NativeTypeName("uint8_t[3]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoVp9SegmentationSegmentationPredProb SegmentationPredProb;

    [NativeName("FeatureEnabled")]
    [NativeTypeName("uint8_t[8]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoVp9SegmentationFeatureEnabled FeatureEnabled;

    [NativeName("FeatureData")]
    [NativeTypeName("int16_t[8][4]")]
    [SupportedApiProfile("vulkan")]
    public StdVideoVp9SegmentationFeatureData FeatureData;
}
