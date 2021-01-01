// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags()]
    [NativeName("Name", "VkExternalMemoryHandleTypeFlagsNV")]
    public enum ExternalMemoryHandleTypeFlagsNV : int
    {
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_BIT_NV")]
        ExternalMemoryHandleTypeOpaqueWin32BitNV = 1,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_OPAQUE_WIN32_KMT_BIT_NV")]
        ExternalMemoryHandleTypeOpaqueWin32KmtBitNV = 2,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_BIT_NV")]
        ExternalMemoryHandleTypeD3D11ImageBitNV = 4,
        [NativeName("Name", "VK_EXTERNAL_MEMORY_HANDLE_TYPE_D3D11_IMAGE_KMT_BIT_NV")]
        ExternalMemoryHandleTypeD3D11ImageKmtBitNV = 8,
    }
}
