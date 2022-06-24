// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkExternalMemoryHandleTypeFlagsNV")]
    public enum ExternalMemoryHandleTypeFlagsNV : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"OpaqueWin32BitNV\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT_NV")]
        ExternalMemoryHandleTypeOpaqueWin32BitNV = 1,
        [Obsolete("Deprecated in favour of \"OpaqueWin32KmtBitNV\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_NV")]
        ExternalMemoryHandleTypeOpaqueWin32KmtBitNV = 2,
        [Obsolete("Deprecated in favour of \"D3D11ImageBitNV\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_BIT_NV")]
        ExternalMemoryHandleTypeD3D11ImageBitNV = 4,
        [Obsolete("Deprecated in favour of \"D3D11ImageKmtBitNV\"")]
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_KMT_BIT_NV")]
        ExternalMemoryHandleTypeD3D11ImageKmtBitNV = 8,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT_NV")]
        OpaqueWin32BitNV = 1,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_NV")]
        OpaqueWin32KmtBitNV = 2,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_BIT_NV")]
        D3D11ImageBitNV = 4,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_KMT_BIT_NV")]
        D3D11ImageKmtBitNV = 8,
    }
}
