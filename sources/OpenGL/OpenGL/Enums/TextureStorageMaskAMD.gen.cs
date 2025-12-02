// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureStorageMaskAMD")]
[Flags]
public enum TextureStorageMaskAMD : uint
{
    None = 0x0,

    [NativeName("GL_TEXTURE_STORAGE_SPARSE_BIT_AMD")]
    TextureStorageSparseBit = unchecked((uint)0x00000001),
}
