// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ExternalHandleType")]
public enum ExternalHandleType : uint
{
    [NativeName("GL_HANDLE_TYPE_OPAQUE_FD_EXT")]
    OpaqueFdEXT = unchecked((uint)0x9586),

    [NativeName("GL_HANDLE_TYPE_OPAQUE_WIN32_EXT")]
    OpaqueWin32EXT = unchecked((uint)0x9587),

    [NativeName("GL_HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT")]
    OpaqueWin32KmtEXT = unchecked((uint)0x9588),

    [NativeName("GL_HANDLE_TYPE_D3D12_TILEPOOL_EXT")]
    D3D12TilepoolEXT = unchecked((uint)0x9589),

    [NativeName("GL_HANDLE_TYPE_D3D12_RESOURCE_EXT")]
    D3D12ResourceEXT = unchecked((uint)0x958A),

    [NativeName("GL_HANDLE_TYPE_D3D11_IMAGE_EXT")]
    D3D11ImageEXT = unchecked((uint)0x958B),

    [NativeName("GL_HANDLE_TYPE_D3D11_IMAGE_KMT_EXT")]
    D3D11ImageKmtEXT = unchecked((uint)0x958C),

    [NativeName("GL_HANDLE_TYPE_D3D12_FENCE_EXT")]
    D3D12FenceEXT = unchecked((uint)0x9594),
}
