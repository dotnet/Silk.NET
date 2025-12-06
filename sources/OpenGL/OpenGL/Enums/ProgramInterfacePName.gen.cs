// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ProgramInterfacePName")]
public enum ProgramInterfacePName : uint
{
    [NativeName("GL_ACTIVE_RESOURCES")]
    ActiveResources = 37621,

    [NativeName("GL_MAX_NAME_LENGTH")]
    MaxNameLength = 37622,

    [NativeName("GL_MAX_NUM_ACTIVE_VARIABLES")]
    MaxNumActiveVariables = 37623,

    [NativeName("GL_MAX_NUM_COMPATIBLE_SUBROUTINES")]
    MaxNumCompatibleSubroutines = 37624,
}
