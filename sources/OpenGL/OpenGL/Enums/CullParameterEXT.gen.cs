// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("CullParameterEXT")]
public enum CullParameterEXT : uint
{
    [NativeName("GL_CULL_VERTEX_EYE_POSITION_EXT")]
    EyePositionEXT = unchecked((uint)0x81AB),

    [NativeName("GL_CULL_VERTEX_OBJECT_POSITION_EXT")]
    ObjectPositionEXT = unchecked((uint)0x81AC),
}
