// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ExternalHandleType")]
[Transformed]
public enum ExternalHandleType : uint
{
    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HANDLE_TYPE_OPAQUE_FD_EXT")]
    OpaqueFdext = unchecked((uint)0x9586),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HANDLE_TYPE_OPAQUE_WIN32_EXT")]
    OpaqueWin32Ext = unchecked((uint)0x9587),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HANDLE_TYPE_OPAQUE_WIN32_KMT_EXT")]
    OpaqueWin32Kmtext = unchecked((uint)0x9588),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HANDLE_TYPE_D3D12_TILEPOOL_EXT")]
    D3D12Tilepoolext = unchecked((uint)0x9589),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HANDLE_TYPE_D3D12_RESOURCE_EXT")]
    D3D12Resourceext = unchecked((uint)0x958A),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HANDLE_TYPE_D3D11_IMAGE_EXT")]
    D3D11Imageext = unchecked((uint)0x958B),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HANDLE_TYPE_D3D11_IMAGE_KMT_EXT")]
    D3D11ImageKmtext = unchecked((uint)0x958C),

    [NameAffix("Suffix", "EXT", 0)]
    [NativeName("GL_HANDLE_TYPE_D3D12_FENCE_EXT")]
    D3D12Fenceext = unchecked((uint)0x9594),
}
