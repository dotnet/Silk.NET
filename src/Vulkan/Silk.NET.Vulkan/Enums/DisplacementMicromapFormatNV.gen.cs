// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDisplacementMicromapFormatNV")]
    public enum DisplacementMicromapFormatNV : int
    {
        [Obsolete("Deprecated in favour of \"Format64Triangles64BytesNV\"")]
        [NativeName("Name", "VK_DISPLACEMENT_MICROMAP_FORMAT_64_TRIANGLES_64_BYTES_NV")]
        DisplacementMicromapFormat64Triangles64BytesNV = 1,
        [Obsolete("Deprecated in favour of \"Format256Triangles128BytesNV\"")]
        [NativeName("Name", "VK_DISPLACEMENT_MICROMAP_FORMAT_256_TRIANGLES_128_BYTES_NV")]
        DisplacementMicromapFormat256Triangles128BytesNV = 2,
        [Obsolete("Deprecated in favour of \"Format1024Triangles128BytesNV\"")]
        [NativeName("Name", "VK_DISPLACEMENT_MICROMAP_FORMAT_1024_TRIANGLES_128_BYTES_NV")]
        DisplacementMicromapFormat1024Triangles128BytesNV = 3,
        [NativeName("Name", "VK_DISPLACEMENT_MICROMAP_FORMAT_64_TRIANGLES_64_BYTES_NV")]
        Format64Triangles64BytesNV = 1,
        [NativeName("Name", "VK_DISPLACEMENT_MICROMAP_FORMAT_256_TRIANGLES_128_BYTES_NV")]
        Format256Triangles128BytesNV = 2,
        [NativeName("Name", "VK_DISPLACEMENT_MICROMAP_FORMAT_1024_TRIANGLES_128_BYTES_NV")]
        Format1024Triangles128BytesNV = 3,
    }
}
