// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkImageViewType")]
    public enum ImageViewType : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Type1D\"")]
        [NativeName("Name", "VK_IMAGE_VIEW_TYPE_1D")]
        ImageViewType1D = 0,
        [Obsolete("Deprecated in favour of \"Type2D\"")]
        [NativeName("Name", "VK_IMAGE_VIEW_TYPE_2D")]
        ImageViewType2D = 1,
        [Obsolete("Deprecated in favour of \"Type3D\"")]
        [NativeName("Name", "VK_IMAGE_VIEW_TYPE_3D")]
        ImageViewType3D = 2,
        [Obsolete("Deprecated in favour of \"TypeCube\"")]
        [NativeName("Name", "VK_IMAGE_VIEW_TYPE_CUBE")]
        Cube = 3,
        [Obsolete("Deprecated in favour of \"Type1DArray\"")]
        [NativeName("Name", "VK_IMAGE_VIEW_TYPE_1D_ARRAY")]
        ImageViewType1DArray = 4,
        [Obsolete("Deprecated in favour of \"Type2DArray\"")]
        [NativeName("Name", "VK_IMAGE_VIEW_TYPE_2D_ARRAY")]
        ImageViewType2DArray = 5,
        [Obsolete("Deprecated in favour of \"TypeCubeArray\"")]
        [NativeName("Name", "VK_IMAGE_VIEW_TYPE_CUBE_ARRAY")]
        CubeArray = 6,
        [NativeName("Name", "VK_IMAGE_VIEW_TYPE_1D")]
        Type1D = 0,
        [NativeName("Name", "VK_IMAGE_VIEW_TYPE_2D")]
        Type2D = 1,
        [NativeName("Name", "VK_IMAGE_VIEW_TYPE_3D")]
        Type3D = 2,
        [NativeName("Name", "VK_IMAGE_VIEW_TYPE_CUBE")]
        TypeCube = 3,
        [NativeName("Name", "VK_IMAGE_VIEW_TYPE_1D_ARRAY")]
        Type1DArray = 4,
        [NativeName("Name", "VK_IMAGE_VIEW_TYPE_2D_ARRAY")]
        Type2DArray = 5,
        [NativeName("Name", "VK_IMAGE_VIEW_TYPE_CUBE_ARRAY")]
        TypeCubeArray = 6,
    }
}
