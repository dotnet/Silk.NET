// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoVP9Segmentation")]
public partial struct StdVideoVp9Segmentation
{
    [NativeName("flags")]
    public StdVideoVp9SegmentationFlags Flags;

    [NativeName("segmentation_tree_probs")]
    public StdVideoVp9SegmentationSegmentationTreeProbs SegmentationTreeProbs;

    [NativeName("segmentation_pred_prob")]
    public StdVideoVp9SegmentationSegmentationPredProb SegmentationPredProb;

    [NativeName("FeatureEnabled")]
    public StdVideoVp9SegmentationFeatureEnabled FeatureEnabled;

    [NativeName("FeatureData")]
    public StdVideoVp9SegmentationFeatureData FeatureData;
}
