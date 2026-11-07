// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkVideoEncodeAV1PredictionModeKHR")]
public enum VideoEncodeAv1PredictionModeKHR : uint
{
    [NativeName("VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_INTRA_ONLY_KHR")]
    IntraOnly = 0,

    [NativeName("VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_SINGLE_REFERENCE_KHR")]
    SingleReference = 1,

    [NativeName("VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_UNIDIRECTIONAL_COMPOUND_KHR")]
    UnidirectionalCompound = 2,

    [NativeName("VK_VIDEO_ENCODE_AV1_PREDICTION_MODE_BIDIRECTIONAL_COMPOUND_KHR")]
    BidirectionalCompound = 3,
}
