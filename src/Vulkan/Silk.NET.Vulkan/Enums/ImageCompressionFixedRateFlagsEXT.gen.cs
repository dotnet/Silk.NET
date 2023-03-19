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
        [Obsolete("Deprecated in favour of \"RateNoneExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_NONE_EXT")]
        ImageCompressionFixedRateNoneExt = 0,
        [Obsolete("Deprecated in favour of \"Rate1BpcBitExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_1BPC_BIT_EXT")]
        ImageCompressionFixedRate1BpcBitExt = 1,
        [Obsolete("Deprecated in favour of \"Rate2BpcBitExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_2BPC_BIT_EXT")]
        ImageCompressionFixedRate2BpcBitExt = 2,
        [Obsolete("Deprecated in favour of \"Rate3BpcBitExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_3BPC_BIT_EXT")]
        ImageCompressionFixedRate3BpcBitExt = 4,
        [Obsolete("Deprecated in favour of \"Rate4BpcBitExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_4BPC_BIT_EXT")]
        ImageCompressionFixedRate4BpcBitExt = 8,
        [Obsolete("Deprecated in favour of \"Rate5BpcBitExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_5BPC_BIT_EXT")]
        ImageCompressionFixedRate5BpcBitExt = 16,
        [Obsolete("Deprecated in favour of \"Rate6BpcBitExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_6BPC_BIT_EXT")]
        ImageCompressionFixedRate6BpcBitExt = 32,
        [Obsolete("Deprecated in favour of \"Rate7BpcBitExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_7BPC_BIT_EXT")]
        ImageCompressionFixedRate7BpcBitExt = 64,
        [Obsolete("Deprecated in favour of \"Rate8BpcBitExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_8BPC_BIT_EXT")]
        ImageCompressionFixedRate8BpcBitExt = 128,
        [Obsolete("Deprecated in favour of \"Rate9BpcBitExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_9BPC_BIT_EXT")]
        ImageCompressionFixedRate9BpcBitExt = 256,
        [Obsolete("Deprecated in favour of \"Rate10BpcBitExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_10BPC_BIT_EXT")]
        ImageCompressionFixedRate10BpcBitExt = 512,
        [Obsolete("Deprecated in favour of \"Rate11BpcBitExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_11BPC_BIT_EXT")]
        ImageCompressionFixedRate11BpcBitExt = 1024,
        [Obsolete("Deprecated in favour of \"Rate12BpcBitExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_12BPC_BIT_EXT")]
        ImageCompressionFixedRate12BpcBitExt = 2048,
        [Obsolete("Deprecated in favour of \"Rate13BpcBitExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_13BPC_BIT_EXT")]
        ImageCompressionFixedRate13BpcBitExt = 4096,
        [Obsolete("Deprecated in favour of \"Rate14BpcBitExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_14BPC_BIT_EXT")]
        ImageCompressionFixedRate14BpcBitExt = 8192,
        [Obsolete("Deprecated in favour of \"Rate15BpcBitExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_15BPC_BIT_EXT")]
        ImageCompressionFixedRate15BpcBitExt = 16384,
        [Obsolete("Deprecated in favour of \"Rate16BpcBitExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_16BPC_BIT_EXT")]
        ImageCompressionFixedRate16BpcBitExt = 32768,
        [Obsolete("Deprecated in favour of \"Rate17BpcBitExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_17BPC_BIT_EXT")]
        ImageCompressionFixedRate17BpcBitExt = 65536,
        [Obsolete("Deprecated in favour of \"Rate18BpcBitExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_18BPC_BIT_EXT")]
        ImageCompressionFixedRate18BpcBitExt = 131072,
        [Obsolete("Deprecated in favour of \"Rate19BpcBitExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_19BPC_BIT_EXT")]
        ImageCompressionFixedRate19BpcBitExt = 262144,
        [Obsolete("Deprecated in favour of \"Rate20BpcBitExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_20BPC_BIT_EXT")]
        ImageCompressionFixedRate20BpcBitExt = 524288,
        [Obsolete("Deprecated in favour of \"Rate21BpcBitExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_21BPC_BIT_EXT")]
        ImageCompressionFixedRate21BpcBitExt = 1048576,
        [Obsolete("Deprecated in favour of \"Rate22BpcBitExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_22BPC_BIT_EXT")]
        ImageCompressionFixedRate22BpcBitExt = 2097152,
        [Obsolete("Deprecated in favour of \"Rate23BpcBitExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_23BPC_BIT_EXT")]
        ImageCompressionFixedRate23BpcBitExt = 4194304,
        [Obsolete("Deprecated in favour of \"Rate24BpcBitExt\"")]
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_24BPC_BIT_EXT")]
        ImageCompressionFixedRate24BpcBitExt = 8388608,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_NONE_EXT")]
        RateNoneExt = 0,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_1BPC_BIT_EXT")]
        Rate1BpcBitExt = 1,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_2BPC_BIT_EXT")]
        Rate2BpcBitExt = 2,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_3BPC_BIT_EXT")]
        Rate3BpcBitExt = 4,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_4BPC_BIT_EXT")]
        Rate4BpcBitExt = 8,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_5BPC_BIT_EXT")]
        Rate5BpcBitExt = 16,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_6BPC_BIT_EXT")]
        Rate6BpcBitExt = 32,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_7BPC_BIT_EXT")]
        Rate7BpcBitExt = 64,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_8BPC_BIT_EXT")]
        Rate8BpcBitExt = 128,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_9BPC_BIT_EXT")]
        Rate9BpcBitExt = 256,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_10BPC_BIT_EXT")]
        Rate10BpcBitExt = 512,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_11BPC_BIT_EXT")]
        Rate11BpcBitExt = 1024,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_12BPC_BIT_EXT")]
        Rate12BpcBitExt = 2048,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_13BPC_BIT_EXT")]
        Rate13BpcBitExt = 4096,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_14BPC_BIT_EXT")]
        Rate14BpcBitExt = 8192,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_15BPC_BIT_EXT")]
        Rate15BpcBitExt = 16384,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_16BPC_BIT_EXT")]
        Rate16BpcBitExt = 32768,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_17BPC_BIT_EXT")]
        Rate17BpcBitExt = 65536,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_18BPC_BIT_EXT")]
        Rate18BpcBitExt = 131072,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_19BPC_BIT_EXT")]
        Rate19BpcBitExt = 262144,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_20BPC_BIT_EXT")]
        Rate20BpcBitExt = 524288,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_21BPC_BIT_EXT")]
        Rate21BpcBitExt = 1048576,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_22BPC_BIT_EXT")]
        Rate22BpcBitExt = 2097152,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_23BPC_BIT_EXT")]
        Rate23BpcBitExt = 4194304,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_24BPC_BIT_EXT")]
        Rate24BpcBitExt = 8388608,
    }
}
