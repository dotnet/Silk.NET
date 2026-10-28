// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkImageType")]
public enum ImageType : uint
{
    [NativeName("VK_IMAGE_TYPE_1D")]
    Type1D = 0,

    [NativeName("VK_IMAGE_TYPE_2D")]
    Type2D = 1,

    [NativeName("VK_IMAGE_TYPE_3D")]
    Type3D = 2,
}
