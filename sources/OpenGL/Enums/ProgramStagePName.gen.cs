// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ProgramStagePName : uint
{
    Subroutines = 0x8DE5,
    SubroutineUniforms = 0x8DE6,
    SubroutineUniformLocations = 0x8E47,
    SubroutineMaxLength = 0x8E48,
    SubroutineUniformMaxLength = 0x8E49
}
