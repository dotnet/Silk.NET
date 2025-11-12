// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum ProgramStagePName : uint
{
    Subroutines = unchecked((uint)0x8DE5),
    SubroutineUniforms = unchecked((uint)0x8DE6),
    SubroutineUniformLocations = unchecked((uint)0x8E47),
    SubroutineMaxLength = unchecked((uint)0x8E48),
    SubroutineUniformMaxLength = unchecked((uint)0x8E49),
}
