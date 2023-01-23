// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkStencilFaceFlags")]
    public enum StencilFaceFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"FaceFrontBit\"")]
        [NativeName("Name", "VK_STENCIL_FACE_FRONT_BIT")]
        StencilFaceFrontBit = 1,
        [Obsolete("Deprecated in favour of \"FaceBackBit\"")]
        [NativeName("Name", "VK_STENCIL_FACE_BACK_BIT")]
        StencilFaceBackBit = 2,
        [Obsolete("Deprecated in favour of \"FaceFrontAndBack\"")]
        [NativeName("Name", "VK_STENCIL_FACE_FRONT_AND_BACK")]
        StencilFaceFrontAndBack = 3,
        [Obsolete("Deprecated in favour of \"FrontAndBack\"")]
        [NativeName("Name", "VK_STENCIL_FRONT_AND_BACK")]
        StencilFrontAndBack = 3,
        [NativeName("Name", "VK_STENCIL_FACE_FRONT_BIT")]
        FaceFrontBit = 1,
        [NativeName("Name", "VK_STENCIL_FACE_BACK_BIT")]
        FaceBackBit = 2,
        [NativeName("Name", "VK_STENCIL_FACE_FRONT_AND_BACK")]
        FaceFrontAndBack = 3,
        [NativeName("Name", "VK_STENCIL_FRONT_AND_BACK")]
        FrontAndBack = 3,
    }
}
