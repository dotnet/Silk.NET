// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("AtomicCounterBufferPName")]
[Transformed]
public enum AtomicCounterBufferPName : uint
{
    [NativeName("GL_ATOMIC_COUNTER_BUFFER_BINDING")]
    Binding = unchecked((uint)0x92C1),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE")]
    DataSize = unchecked((uint)0x92C4),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS")]
    ActiveAtomicCounters = unchecked((uint)0x92C5),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES")]
    ActiveAtomicCounterIndices = unchecked((uint)0x92C6),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER")]
    ReferencedByVertexShader = unchecked((uint)0x92C7),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER")]
    ReferencedByTessControlShader = unchecked((uint)0x92C8),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER")]
    ReferencedByTessEvaluationShader = unchecked((uint)0x92C9),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER")]
    ReferencedByGeometryShader = unchecked((uint)0x92CA),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER")]
    ReferencedByFragmentShader = unchecked((uint)0x92CB),

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER")]
    ReferencedByComputeShader = unchecked((uint)0x90ED),
}
