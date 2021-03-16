// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkImageType")]
    public enum ImageType : int
    {
        [NativeName("Name", "VK_IMAGE_TYPE_1D")]
        ImageType1D = 0,
        [NativeName("Name", "VK_IMAGE_TYPE_2D")]
        ImageType2D = 1,
        [NativeName("Name", "VK_IMAGE_TYPE_3D")]
        ImageType3D = 2,
    }
}
