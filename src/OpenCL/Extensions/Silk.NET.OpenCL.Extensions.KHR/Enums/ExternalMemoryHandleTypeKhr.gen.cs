// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.KHR
{
    [NativeName("Name", "cl_external_memory_handle_type_khr")]
    public enum ExternalMemoryHandleTypeKhr : int
    {
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_DMA_BUF_KHR")]
        ExternalMemoryHandleDmaBufKhr = 0x2067,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_D3D11_TEXTURE_KHR")]
        ExternalMemoryHandleD3D11TextureKhr = 0x2063,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_D3D11_TEXTURE_KMT_KHR")]
        ExternalMemoryHandleD3D11TextureKmtKhr = 0x2064,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_D3D12_HEAP_KHR")]
        ExternalMemoryHandleD3D12HeapKhr = 0x2065,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_D3D12_RESOURCE_KHR")]
        ExternalMemoryHandleD3D12ResourceKhr = 0x2066,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_OPAQUE_FD_KHR")]
        ExternalMemoryHandleOpaqueFDKhr = 0x2060,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_OPAQUE_WIN32_KHR")]
        ExternalMemoryHandleOpaqueWin32Khr = 0x2061,
        [NativeName("Name", "CL_EXTERNAL_MEMORY_HANDLE_OPAQUE_WIN32_KMT_KHR")]
        ExternalMemoryHandleOpaqueWin32KmtKhr = 0x2062,
    }
}
