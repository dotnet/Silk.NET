// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkTessellationDomainOrigin")]
    public enum TessellationDomainOrigin : int
    {
        [NativeName("Name", "VK_TESSELLATION_DOMAIN_ORIGIN_UPPER_LEFT")]
        UpperLeft = 0,
        [NativeName("Name", "VK_TESSELLATION_DOMAIN_ORIGIN_LOWER_LEFT")]
        LowerLeft = 1,
    }
}
