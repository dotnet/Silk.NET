// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureCompareMode")]
[Transformed]
public enum TextureCompareMode : uint
{
    [NativeName("GL_NONE")]
    None = unchecked((uint)0),

    [NativeName("GL_COMPARE_R_TO_TEXTURE")]
    CompareRToTexture = unchecked((uint)0x884E),

    [NativeName("GL_COMPARE_REF_TO_TEXTURE")]
    CompareRefToTexture = unchecked((uint)0x884E),
}
