// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("PerfQueryDataFlags")]
[Transformed]
public enum PerfQueryDataFlags : uint
{
    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_WAIT_INTEL")]
    WaitINTEL = unchecked((uint)0x83FB),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_FLUSH_INTEL")]
    FlushINTEL = unchecked((uint)0x83FA),

    [NameAffix("Suffix", "INTEL", 0)]
    [NativeName("GL_PERFQUERY_DONOT_FLUSH_INTEL")]
    DonotFlushINTEL = unchecked((uint)0x83F9),
}
