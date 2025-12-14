// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDefaultVertexAttributeValueKHR")]
    public enum DefaultVertexAttributeValueKHR : int
    {
        [Obsolete("Deprecated in favour of \"ZeroKhr\"")]
        [NativeName("Name", "VK_DEFAULT_VERTEX_ATTRIBUTE_VALUE_ZERO_ZERO_ZERO_ZERO_KHR")]
        DefaultVertexAttributeValueZeroZeroZeroZeroKhr = 0,
        [Obsolete("Deprecated in favour of \"OneKhr\"")]
        [NativeName("Name", "VK_DEFAULT_VERTEX_ATTRIBUTE_VALUE_ZERO_ZERO_ZERO_ONE_KHR")]
        DefaultVertexAttributeValueZeroZeroZeroOneKhr = 1,
        [NativeName("Name", "VK_DEFAULT_VERTEX_ATTRIBUTE_VALUE_ZERO_ZERO_ZERO_ZERO_KHR")]
        ZeroKhr = 0,
        [NativeName("Name", "VK_DEFAULT_VERTEX_ATTRIBUTE_VALUE_ZERO_ZERO_ZERO_ONE_KHR")]
        OneKhr = 1,
    }
}
