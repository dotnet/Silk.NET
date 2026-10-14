// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("DebugSource")]
public enum DebugSource : uint
{
    [NativeName("GL_DONT_CARE")]
    DontCare = 4352,

    [NativeName("GL_DEBUG_SOURCE_API")]
    DebugSourceApi = 33350,

    [NativeName("GL_DEBUG_SOURCE_WINDOW_SYSTEM")]
    DebugSourceWindowSystem = 33351,

    [NativeName("GL_DEBUG_SOURCE_SHADER_COMPILER")]
    DebugSourceShaderCompiler = 33352,

    [NativeName("GL_DEBUG_SOURCE_THIRD_PARTY")]
    DebugSourceThirdParty = 33353,

    [NativeName("GL_DEBUG_SOURCE_APPLICATION")]
    DebugSourceApplication = 33354,

    [NativeName("GL_DEBUG_SOURCE_OTHER")]
    DebugSourceOther = 33355,
}
