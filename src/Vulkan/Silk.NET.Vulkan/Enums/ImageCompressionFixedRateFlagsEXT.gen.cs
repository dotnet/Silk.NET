// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkImageCompressionFixedRateFlagsEXT")]
    public enum ImageCompressionFixedRateFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_NONE_EXT")]
        ImageCompressionFixedRateNoneExt = 0,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_1BPC_BIT_EXT")]
        ImageCompressionFixedRate1BpcBitExt = 1,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_2BPC_BIT_EXT")]
        ImageCompressionFixedRate2BpcBitExt = 2,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_3BPC_BIT_EXT")]
        ImageCompressionFixedRate3BpcBitExt = 4,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_4BPC_BIT_EXT")]
        ImageCompressionFixedRate4BpcBitExt = 8,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_5BPC_BIT_EXT")]
        ImageCompressionFixedRate5BpcBitExt = 16,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_6BPC_BIT_EXT")]
        ImageCompressionFixedRate6BpcBitExt = 32,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_7BPC_BIT_EXT")]
        ImageCompressionFixedRate7BpcBitExt = 64,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_8BPC_BIT_EXT")]
        ImageCompressionFixedRate8BpcBitExt = 128,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_9BPC_BIT_EXT")]
        ImageCompressionFixedRate9BpcBitExt = 256,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_10BPC_BIT_EXT")]
        ImageCompressionFixedRate10BpcBitExt = 512,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_11BPC_BIT_EXT")]
        ImageCompressionFixedRate11BpcBitExt = 1024,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_12BPC_BIT_EXT")]
        ImageCompressionFixedRate12BpcBitExt = 2048,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_13BPC_BIT_EXT")]
        ImageCompressionFixedRate13BpcBitExt = 4096,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_14BPC_BIT_EXT")]
        ImageCompressionFixedRate14BpcBitExt = 8192,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_15BPC_BIT_EXT")]
        ImageCompressionFixedRate15BpcBitExt = 16384,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_16BPC_BIT_EXT")]
        ImageCompressionFixedRate16BpcBitExt = 32768,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_17BPC_BIT_EXT")]
        ImageCompressionFixedRate17BpcBitExt = 65536,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_18BPC_BIT_EXT")]
        ImageCompressionFixedRate18BpcBitExt = 131072,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_19BPC_BIT_EXT")]
        ImageCompressionFixedRate19BpcBitExt = 262144,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_20BPC_BIT_EXT")]
        ImageCompressionFixedRate20BpcBitExt = 524288,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_21BPC_BIT_EXT")]
        ImageCompressionFixedRate21BpcBitExt = 1048576,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_22BPC_BIT_EXT")]
        ImageCompressionFixedRate22BpcBitExt = 2097152,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_23BPC_BIT_EXT")]
        ImageCompressionFixedRate23BpcBitExt = 4194304,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_24BPC_BIT_EXT")]
        ImageCompressionFixedRate24BpcBitExt = 8388608,
    }
}
