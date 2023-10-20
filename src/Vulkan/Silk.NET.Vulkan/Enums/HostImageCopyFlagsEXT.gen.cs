// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkHostImageCopyFlagsEXT")]
    public enum HostImageCopyFlagsEXT : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"MemcpyExt\"")]
        [NativeName("Name", "VK_HOST_IMAGE_COPY_MEMCPY_EXT")]
        HostImageCopyMemcpyExt = 1,
        [NativeName("Name", "VK_HOST_IMAGE_COPY_MEMCPY_EXT")]
        MemcpyExt = 1,
    }
}
