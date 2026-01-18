// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureEnvTarget")]
public enum TextureEnvTarget : uint
{
    [NativeName("GL_TEXTURE_ENV")]
    TextureENV = 8960,

    [NativeName("GL_TEXTURE_FILTER_CONTROL")]
    TextureFilterControl = 34048,

    [NativeName("GL_POINT_SPRITE")]
    PointSprite = 34913,
}
