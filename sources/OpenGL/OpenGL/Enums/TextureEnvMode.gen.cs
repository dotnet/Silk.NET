// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("TextureEnvMode")]
public enum TextureEnvMode : uint
{
    [NativeName("GL_BLEND")]
    Blend = 3042,

    [NativeName("GL_REPLACE")]
    Replace = 7681,

    [NativeName("GL_ADD")]
    Add = 260,

    [NativeName("GL_MODULATE")]
    Modulate = 8448,

    [NativeName("GL_DECAL")]
    Decal = 8449,

    [NativeName("GL_COMBINE")]
    Combine = 34160,

    [NativeName("GL_REPLACE_EXT")]
    ReplaceEXT = 32866,

    [NativeName("GL_TEXTURE_ENV_BIAS_SGIX")]
    TextureEnvBiasSGIX = 32958,
}
