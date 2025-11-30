// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ProgramStagePName")]
[Transformed]
public enum ProgramStagePName : uint
{
    [NativeName("GL_ACTIVE_SUBROUTINES")]
    Subroutines = unchecked((uint)0x8DE5),

    [NativeName("GL_ACTIVE_SUBROUTINE_UNIFORMS")]
    SubroutineUniforms = unchecked((uint)0x8DE6),

    [NativeName("GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS")]
    SubroutineUniformLocations = unchecked((uint)0x8E47),

    [NativeName("GL_ACTIVE_SUBROUTINE_MAX_LENGTH")]
    SubroutineMaxLength = unchecked((uint)0x8E48),

    [NativeName("GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH")]
    SubroutineUniformMaxLength = unchecked((uint)0x8E49),
}
