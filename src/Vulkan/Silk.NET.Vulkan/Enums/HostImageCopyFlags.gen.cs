// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkHostImageCopyFlags")]
    public enum HostImageCopyFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"MemcpyBit\"")]
        [NativeName("Name", "VK_HOST_IMAGE_COPY_MEMCPY_BIT")]
        HostImageCopyMemcpyBit = 1,
        [Obsolete("Deprecated in favour of \"Memcpy\"")]
        [NativeName("Name", "VK_HOST_IMAGE_COPY_MEMCPY")]
        HostImageCopyMemcpy = 1,
        [NativeName("Name", "VK_HOST_IMAGE_COPY_MEMCPY_BIT")]
        MemcpyBit = 1,
        [NativeName("Name", "VK_HOST_IMAGE_COPY_MEMCPY")]
        Memcpy = 1,
    }
}
