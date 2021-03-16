// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "ExternalHandleType")]
    public enum ExternalHandleType : int
    {
        [NativeName("Name", "GL_HANDLE_TYPE_OPAQUE_FD_EXT")]
        HandleTypeOpaqueFDExt = 0x9586,
        [NativeName("Name", "GL_HANDLE_TYPE_OPAQUE_WIN32_EXT")]
        HandleTypeOpaqueWin32Ext = 0x9587,
        [NativeName("Name", "GL_HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT")]
        HandleTypeOpaqueWin32KmtExt = 0x9588,
        [NativeName("Name", "GL_HANDLE_TYPE_D3D12_TILEPOOL_EXT")]
        HandleTypeD3D12TilepoolExt = 0x9589,
        [NativeName("Name", "GL_HANDLE_TYPE_D3D12_RESOURCE_EXT")]
        HandleTypeD3D12ResourceExt = 0x958A,
        [NativeName("Name", "GL_HANDLE_TYPE_D3D11_IMAGE_EXT")]
        HandleTypeD3D11ImageExt = 0x958B,
        [NativeName("Name", "GL_HANDLE_TYPE_D3D11_IMAGE_KMT_EXT")]
        HandleTypeD3D11ImageKmtExt = 0x958C,
        [NativeName("Name", "GL_HANDLE_TYPE_D3D12_FENCE_EXT")]
        HandleTypeD3D12FenceExt = 0x9594,
    }
}
