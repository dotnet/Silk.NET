// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkTensorTilingARM")]
    public enum TensorTilingARM : int
    {
        [Obsolete("Deprecated in favour of \"OptimalArm\"")]
        [NativeName("Name", "VK_TENSOR_TILING_OPTIMAL_ARM")]
        TensorTilingOptimalArm = 0,
        [Obsolete("Deprecated in favour of \"LinearArm\"")]
        [NativeName("Name", "VK_TENSOR_TILING_LINEAR_ARM")]
        TensorTilingLinearArm = 1,
        [NativeName("Name", "VK_TENSOR_TILING_OPTIMAL_ARM")]
        OptimalArm = 0,
        [NativeName("Name", "VK_TENSOR_TILING_LINEAR_ARM")]
        LinearArm = 1,
    }
}
