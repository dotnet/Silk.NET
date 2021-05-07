// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkVideoCapabilitiesFlagsKHR")]
    public enum VideoCapabilitiesFlagsKHR : int
    {
        [NativeName("Name", "VK_VIDEO_CAPABILITIES_PROTECTED_CONTENT_BIT_KHR")]
        VideoCapabilitiesProtectedContentBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_CAPABILITIES_SEPARATE_REFERENCE_IMAGES_BIT_KHR")]
        VideoCapabilitiesSeparateReferenceImagesBitKhr = 2,
    }
}
