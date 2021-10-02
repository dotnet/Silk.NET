// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "AtomicCounterBufferPName")]
    public enum AtomicCounterBufferPName : int
    {
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER")]
        AtomicCounterBufferReferencedByComputeShader = 0x90ED,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_BINDING")]
        AtomicCounterBufferBinding = 0x92C1,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE")]
        AtomicCounterBufferDataSize = 0x92C4,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS")]
        AtomicCounterBufferActiveAtomicCounters = 0x92C5,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES")]
        AtomicCounterBufferActiveAtomicCounterIndices = 0x92C6,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER")]
        AtomicCounterBufferReferencedByVertexShader = 0x92C7,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER")]
        AtomicCounterBufferReferencedByTessControlShader = 0x92C8,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER")]
        AtomicCounterBufferReferencedByTessEvaluationShader = 0x92C9,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER")]
        AtomicCounterBufferReferencedByGeometryShader = 0x92CA,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER")]
        AtomicCounterBufferReferencedByFragmentShader = 0x92CB,
    }
}
