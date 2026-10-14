// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("HintMode")]
public enum HintMode : uint
{
    [NativeName("GL_DONT_CARE")]
    DontCare = 4352,

    [NativeName("GL_FASTEST")]
    Fastest = 4353,

    [NativeName("GL_NICEST")]
    Nicest = 4354,
}
