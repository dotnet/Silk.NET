// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("SubroutineParameterName")]
public enum SubroutineParameterName : uint
{
    [NativeName("GL_UNIFORM_SIZE")]
    UniformSize = 35384,

    [NativeName("GL_UNIFORM_NAME_LENGTH")]
    UniformNameLength = 35385,

    [NativeName("GL_NUM_COMPATIBLE_SUBROUTINES")]
    NumCompatibleSubroutines = 36426,

    [NativeName("GL_COMPATIBLE_SUBROUTINES")]
    CompatibleSubroutines = 36427,
}
