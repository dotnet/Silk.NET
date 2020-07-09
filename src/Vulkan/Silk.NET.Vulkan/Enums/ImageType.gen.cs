// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkImageType")]
    public enum ImageType
    {
        [NativeName("Name", "VK_IMAGE_TYPE_1D")]
        ImageType1D = 0,
        [NativeName("Name", "VK_IMAGE_TYPE_2D")]
        ImageType2D = 1,
        [NativeName("Name", "VK_IMAGE_TYPE_3D")]
        ImageType3D = 2,
    }
}
