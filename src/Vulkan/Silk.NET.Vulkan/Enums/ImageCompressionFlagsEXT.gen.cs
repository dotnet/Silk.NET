// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkImageCompressionFlagsEXT")]
    public enum ImageCompressionFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_DEFAULT_EXT")]
        ImageCompressionDefaultExt = 0,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_DEFAULT_EXT")]
        ImageCompressionFixedRateDefaultExt = 1,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_FIXED_RATE_EXPLICIT_EXT")]
        ImageCompressionFixedRateExplicitExt = 2,
        [NativeName("Name", "VK_IMAGE_COMPRESSION_DISABLED_EXT")]
        ImageCompressionDisabledExt = 4,
    }
}
