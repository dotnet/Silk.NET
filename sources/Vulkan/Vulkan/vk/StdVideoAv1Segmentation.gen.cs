// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("StdVideoAV1Segmentation")]
public partial struct StdVideoAv1Segmentation
{
    [NativeName("FeatureEnabled")]
    public StdVideoAv1SegmentationFeatureEnabled FeatureEnabled;

    [NativeName("FeatureData")]
    public StdVideoAv1SegmentationFeatureData FeatureData;
}
