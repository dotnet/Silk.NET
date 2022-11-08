// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkMemoryDecompressionMethodFlagsNV")]
    public enum MemoryDecompressionMethodFlagsNV : long
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Gdeflate10BitNV\"")]
        [NativeName("Name", "VK_MEMORY_DECOMPRESSION_METHOD_GDEFLATE_1_0_BIT_NV")]
        MemoryDecompressionMethodGdeflate10BitNV = 1,
        [NativeName("Name", "VK_MEMORY_DECOMPRESSION_METHOD_GDEFLATE_1_0_BIT_NV")]
        Gdeflate10BitNV = 1,
    }
}
