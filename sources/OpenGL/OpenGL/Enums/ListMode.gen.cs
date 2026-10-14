// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("ListMode")]
public enum ListMode : uint
{
    [NativeName("GL_COMPILE")]
    Compile = 4864,

    [NativeName("GL_COMPILE_AND_EXECUTE")]
    CompileAndExecute = 4865,
}
