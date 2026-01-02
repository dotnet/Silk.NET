// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ExternalHandleType : uint
{
    OpaqueFdEXT = unchecked((uint)0x9586),
    OpaqueWin32EXT = unchecked((uint)0x9587),
    OpaqueWin32KmtEXT = unchecked((uint)0x9588),
    D3D12TilepoolEXT = unchecked((uint)0x9589),
    D3D12ResourceEXT = unchecked((uint)0x958A),
    D3D11ImageEXT = unchecked((uint)0x958B),
    D3D11ImageKmtEXT = unchecked((uint)0x958C),
    D3D12FenceEXT = unchecked((uint)0x9594),
}
