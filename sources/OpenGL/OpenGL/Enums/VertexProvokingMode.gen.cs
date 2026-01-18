// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("VertexProvokingMode")]
public enum VertexProvokingMode : uint
{
    [NativeName("GL_FIRST_VERTEX_CONVENTION")]
    FirstVertexConvention = 36429,

    [NativeName("GL_LAST_VERTEX_CONVENTION")]
    LastVertexConvention = 36430,
}
