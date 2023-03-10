// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkRasterizationOrderAMD")]
    public enum RasterizationOrderAMD : int
    {
        [Obsolete("Deprecated in favour of \"StrictAmd\"")]
        [NativeName("Name", "VK_RASTERIZATION_ORDER_STRICT_AMD")]
        RasterizationOrderStrictAmd = 0,
        [Obsolete("Deprecated in favour of \"RelaxedAmd\"")]
        [NativeName("Name", "VK_RASTERIZATION_ORDER_RELAXED_AMD")]
        RasterizationOrderRelaxedAmd = 1,
        [NativeName("Name", "VK_RASTERIZATION_ORDER_STRICT_AMD")]
        StrictAmd = 0,
        [NativeName("Name", "VK_RASTERIZATION_ORDER_RELAXED_AMD")]
        RelaxedAmd = 1,
    }
}
