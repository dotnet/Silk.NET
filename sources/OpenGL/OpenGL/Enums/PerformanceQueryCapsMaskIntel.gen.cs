// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NameAffix("Suffix", "INTEL", 0)]
[NativeName("PerformanceQueryCapsMaskINTEL")]
[Transformed]
[Flags]
public enum PerformanceQueryCapsMaskIntel : uint
{
    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_SINGLE_CONTEXT_INTEL")]
    SingleContExtintel = unchecked((uint)0x00000000),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_GLOBAL_CONTEXT_INTEL")]
    GlobalContExtintel = unchecked((uint)0x00000001),
}
