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
        [NativeName("Name", "VK_STENCIL_FACE_FRONT_BIT")]
        StencilFaceFrontBit = 1,
        [NativeName("Name", "VK_STENCIL_FACE_BACK_BIT")]
        StencilFaceBackBit = 2,
        [NativeName("Name", "VK_STENCIL_FACE_FRONT_AND_BACK")]
        StencilFaceFrontAndBack = 3,
        [NativeName("Name", "VK_STENCIL_FRONT_AND_BACK")]
        StencilFrontAndBack = 3,
    }
}
