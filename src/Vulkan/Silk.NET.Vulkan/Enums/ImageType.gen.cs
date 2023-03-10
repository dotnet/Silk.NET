// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkImageType")]
    public enum ImageType : int
    {
        [Obsolete("Deprecated in favour of \"Type1D\"")]
        [NativeName("Name", "VK_IMAGE_TYPE_1D")]
        ImageType1D = 0,
        [Obsolete("Deprecated in favour of \"Type2D\"")]
        [NativeName("Name", "VK_IMAGE_TYPE_2D")]
        ImageType2D = 1,
        [Obsolete("Deprecated in favour of \"Type3D\"")]
        [NativeName("Name", "VK_IMAGE_TYPE_3D")]
        ImageType3D = 2,
        [NativeName("Name", "VK_IMAGE_TYPE_1D")]
        Type1D = 0,
        [NativeName("Name", "VK_IMAGE_TYPE_2D")]
        Type2D = 1,
        [NativeName("Name", "VK_IMAGE_TYPE_3D")]
        Type3D = 2,
    }
}
