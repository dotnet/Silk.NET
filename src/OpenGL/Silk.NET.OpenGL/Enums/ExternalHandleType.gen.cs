// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "ExternalHandleType")]
    public enum ExternalHandleType : int
    {
        [Obsolete("Deprecated in favour of \"OpaqueFDExt\"")]
        [NativeName("Name", "GL_HANDLE_TYPE_OPAQUE_FD_EXT")]
        HandleTypeOpaqueFDExt = 0x9586,
        [Obsolete("Deprecated in favour of \"OpaqueWin32Ext\"")]
        [NativeName("Name", "GL_HANDLE_TYPE_OPAQUE_WIN32_EXT")]
        HandleTypeOpaqueWin32Ext = 0x9587,
        [Obsolete("Deprecated in favour of \"OpaqueWin32KmtExt\"")]
        [NativeName("Name", "GL_HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT")]
        HandleTypeOpaqueWin32KmtExt = 0x9588,
        [Obsolete("Deprecated in favour of \"D3D12TilepoolExt\"")]
        [NativeName("Name", "GL_HANDLE_TYPE_D3D12_TILEPOOL_EXT")]
        HandleTypeD3D12TilepoolExt = 0x9589,
        [Obsolete("Deprecated in favour of \"D3D12ResourceExt\"")]
        [NativeName("Name", "GL_HANDLE_TYPE_D3D12_RESOURCE_EXT")]
        HandleTypeD3D12ResourceExt = 0x958A,
        [Obsolete("Deprecated in favour of \"D3D11ImageExt\"")]
        [NativeName("Name", "GL_HANDLE_TYPE_D3D11_IMAGE_EXT")]
        HandleTypeD3D11ImageExt = 0x958B,
        [Obsolete("Deprecated in favour of \"D3D11ImageKmtExt\"")]
        [NativeName("Name", "GL_HANDLE_TYPE_D3D11_IMAGE_KMT_EXT")]
        HandleTypeD3D11ImageKmtExt = 0x958C,
        [Obsolete("Deprecated in favour of \"D3D12FenceExt\"")]
        [NativeName("Name", "GL_HANDLE_TYPE_D3D12_FENCE_EXT")]
        HandleTypeD3D12FenceExt = 0x9594,
        [NativeName("Name", "GL_HANDLE_TYPE_OPAQUE_FD_EXT")]
        OpaqueFDExt = 0x9586,
        [NativeName("Name", "GL_HANDLE_TYPE_OPAQUE_WIN32_EXT")]
        OpaqueWin32Ext = 0x9587,
        [NativeName("Name", "GL_HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT")]
        OpaqueWin32KmtExt = 0x9588,
        [NativeName("Name", "GL_HANDLE_TYPE_D3D12_TILEPOOL_EXT")]
        D3D12TilepoolExt = 0x9589,
        [NativeName("Name", "GL_HANDLE_TYPE_D3D12_RESOURCE_EXT")]
        D3D12ResourceExt = 0x958A,
        [NativeName("Name", "GL_HANDLE_TYPE_D3D11_IMAGE_EXT")]
        D3D11ImageExt = 0x958B,
        [NativeName("Name", "GL_HANDLE_TYPE_D3D11_IMAGE_KMT_EXT")]
        D3D11ImageKmtExt = 0x958C,
        [NativeName("Name", "GL_HANDLE_TYPE_D3D12_FENCE_EXT")]
        D3D12FenceExt = 0x9594,
    }
}
