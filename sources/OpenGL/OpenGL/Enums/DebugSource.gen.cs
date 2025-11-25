// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[Transformed]
public enum DebugSource : uint
{
    DontCare = unchecked((uint)0x1100),
    DebugSourceApi = unchecked((uint)0x8246),
    DebugSourceWindowSystem = unchecked((uint)0x8247),
    DebugSourceShaderCompiler = unchecked((uint)0x8248),
    DebugSourceThirdParty = unchecked((uint)0x8249),
    DebugSourceApplication = unchecked((uint)0x824A),
    DebugSourceOther = unchecked((uint)0x824B),
}
