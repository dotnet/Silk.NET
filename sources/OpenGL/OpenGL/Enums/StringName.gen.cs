// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("StringName")]
[Transformed]
public enum StringName : uint
{
    [NativeName("GL_VENDOR")]
    Vendor = unchecked((uint)0x1F00),

    [NativeName("GL_RENDERER")]
    Renderer = unchecked((uint)0x1F01),

    [NativeName("GL_VERSION")]
    Version = unchecked((uint)0x1F02),

    [NativeName("GL_EXTENSIONS")]
    Extensions = unchecked((uint)0x1F03),

    [NativeName("GL_SHADING_LANGUAGE_VERSION")]
    ShadingLanguageVersion = unchecked((uint)0x8B8C),
}
