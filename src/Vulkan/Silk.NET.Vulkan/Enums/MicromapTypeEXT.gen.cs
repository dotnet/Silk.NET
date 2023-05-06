// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkMicromapTypeEXT")]
    public enum MicromapTypeEXT : int
    {
        [Obsolete("Deprecated in favour of \"OpacityMicromapExt\"")]
        [NativeName("Name", "VK_MICROMAP_TYPE_OPACITY_MICROMAP_EXT")]
        MicromapTypeOpacityMicromapExt = 0,
        [Obsolete("Deprecated in favour of \"DisplacementMicromapNV\"")]
        [NativeName("Name", "VK_MICROMAP_TYPE_DISPLACEMENT_MICROMAP_NV")]
        MicromapTypeDisplacementMicromapNV = 1000397000,
        [NativeName("Name", "VK_MICROMAP_TYPE_OPACITY_MICROMAP_EXT")]
        OpacityMicromapExt = 0,
        [NativeName("Name", "VK_MICROMAP_TYPE_DISPLACEMENT_MICROMAP_NV")]
        DisplacementMicromapNV = 1000397000,
    }
}
