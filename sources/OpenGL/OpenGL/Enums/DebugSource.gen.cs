// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("DebugSource")]
[Transformed]
public enum DebugSource : uint
{
    [NativeName("GL_DONT_CARE")]
    DontCare = unchecked((uint)0x1100),

    [NativeName("GL_DEBUG_SOURCE_API")]
    DebugSourceApi = unchecked((uint)0x8246),

    [NativeName("GL_DEBUG_SOURCE_WINDOW_SYSTEM")]
    DebugSourceWindowSystem = unchecked((uint)0x8247),

    [NativeName("GL_DEBUG_SOURCE_SHADER_COMPILER")]
    DebugSourceShaderCompiler = unchecked((uint)0x8248),

    [NativeName("GL_DEBUG_SOURCE_THIRD_PARTY")]
    DebugSourceThirdParty = unchecked((uint)0x8249),

    [NativeName("GL_DEBUG_SOURCE_APPLICATION")]
    DebugSourceApplication = unchecked((uint)0x824A),

    [NativeName("GL_DEBUG_SOURCE_OTHER")]
    DebugSourceOther = unchecked((uint)0x824B),
}
