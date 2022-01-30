// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoCapabilityFlagsKHR")]
    public enum VideoCapabilityFlagsKHR : int
    {
        [NativeName("Name", "VK_VIDEO_CAPABILITY_PROTECTED_CONTENT_BIT_KHR")]
        VideoCapabilityProtectedContentBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_CAPABILITY_SEPARATE_REFERENCE_IMAGES_BIT_KHR")]
        VideoCapabilitySeparateReferenceImagesBitKhr = 2,
    }
}
