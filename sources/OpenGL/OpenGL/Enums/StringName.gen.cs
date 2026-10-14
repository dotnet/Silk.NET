// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("StringName")]
public enum StringName : uint
{
    [NativeName("GL_VENDOR")]
    Vendor = 7936,

    [NativeName("GL_RENDERER")]
    Renderer = 7937,

    [NativeName("GL_VERSION")]
    Version = 7938,

    [NativeName("GL_EXTENSIONS")]
    Extensions = 7939,

    [NativeName("GL_SHADING_LANGUAGE_VERSION")]
    ShadingLanguageVersion = 35724,
}
