// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkCompressedTriangleFormatAMDX")]
    public enum CompressedTriangleFormatAMDX : int
    {
        [Obsolete("Deprecated in favour of \"Dgf1Amdx\"")]
        [NativeName("Name", "VK_COMPRESSED_TRIANGLE_FORMAT_DGF1_AMDX")]
        CompressedTriangleFormatDgf1Amdx = 0,
        [NativeName("Name", "VK_COMPRESSED_TRIANGLE_FORMAT_DGF1_AMDX")]
        Dgf1Amdx = 0,
    }
}
