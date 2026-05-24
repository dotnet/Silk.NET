// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("AtomicCounterBufferPName")]
public enum AtomicCounterBufferPName : uint
{
    [NativeName("GL_ATOMIC_COUNTER_BUFFER_BINDING")]
    Binding = 37569,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE")]
    DataSize = 37572,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS")]
    ActiveAtomicCounters = 37573,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES")]
    ActiveAtomicCounterIndices = 37574,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER")]
    ReferencedByVertexShader = 37575,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER")]
    ReferencedByTessControlShader = 37576,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER")]
    ReferencedByTessEvaluationShader = 37577,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER")]
    ReferencedByGeometryShader = 37578,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER")]
    ReferencedByFragmentShader = 37579,

    [NativeName("GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER")]
    ReferencedByComputeShader = 37101,
}
