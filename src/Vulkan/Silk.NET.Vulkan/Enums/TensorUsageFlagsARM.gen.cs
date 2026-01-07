// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkTensorUsageFlagsARM")]
    public enum TensorUsageFlagsARM : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ShaderBitArm\"")]
        [NativeName("Name", "VK_TENSOR_USAGE_SHADER_BIT_ARM")]
        TensorUsageShaderBitArm = 2,
        [Obsolete("Deprecated in favour of \"TransferSrcBitArm\"")]
        [NativeName("Name", "VK_TENSOR_USAGE_TRANSFER_SRC_BIT_ARM")]
        TensorUsageTransferSrcBitArm = 4,
        [Obsolete("Deprecated in favour of \"TransferDstBitArm\"")]
        [NativeName("Name", "VK_TENSOR_USAGE_TRANSFER_DST_BIT_ARM")]
        TensorUsageTransferDstBitArm = 8,
        [Obsolete("Deprecated in favour of \"ImageAliasingBitArm\"")]
        [NativeName("Name", "VK_TENSOR_USAGE_IMAGE_ALIASING_BIT_ARM")]
        TensorUsageImageAliasingBitArm = 16,
        [Obsolete("Deprecated in favour of \"DataGraphBitArm\"")]
        [NativeName("Name", "VK_TENSOR_USAGE_DATA_GRAPH_BIT_ARM")]
        TensorUsageDataGraphBitArm = 32,
        [NativeName("Name", "VK_TENSOR_USAGE_SHADER_BIT_ARM")]
        ShaderBitArm = 2,
        [NativeName("Name", "VK_TENSOR_USAGE_TRANSFER_SRC_BIT_ARM")]
        TransferSrcBitArm = 4,
        [NativeName("Name", "VK_TENSOR_USAGE_TRANSFER_DST_BIT_ARM")]
        TransferDstBitArm = 8,
        [NativeName("Name", "VK_TENSOR_USAGE_IMAGE_ALIASING_BIT_ARM")]
        ImageAliasingBitArm = 16,
        [NativeName("Name", "VK_TENSOR_USAGE_DATA_GRAPH_BIT_ARM")]
        DataGraphBitArm = 32,
    }
}
