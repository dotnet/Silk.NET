// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("VertexShaderTextureUnitParameter")]
[Transformed]
public enum VertexShaderTextureUnitParameter : uint
{
    [NativeName("GL_CURRENT_TEXTURE_COORDS")]
    CurrentTextureCoords = unchecked((uint)0x0B03),

    [NativeName("GL_TEXTURE_MATRIX")]
    TextureMatrix = unchecked((uint)0x0BA8),
}
