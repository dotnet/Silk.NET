// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ProgramStagePName")]
public enum ProgramStagePName : uint
{
    [NativeName("GL_ACTIVE_SUBROUTINES")]
    Subroutines = 36325,

    [NativeName("GL_ACTIVE_SUBROUTINE_UNIFORMS")]
    SubroutineUniforms = 36326,

    [NativeName("GL_ACTIVE_SUBROUTINE_UNIFORM_LOCATIONS")]
    SubroutineUniformLocations = 36423,

    [NativeName("GL_ACTIVE_SUBROUTINE_MAX_LENGTH")]
    SubroutineMaxLength = 36424,

    [NativeName("GL_ACTIVE_SUBROUTINE_UNIFORM_MAX_LENGTH")]
    SubroutineUniformMaxLength = 36425,
}
