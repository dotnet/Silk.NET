// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "AtomicCounterBufferPName")]
    public enum AtomicCounterBufferPName : int
    {
        [Obsolete("Deprecated in favour of \"ReferencedByComputeShader\"")]
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER")]
        AtomicCounterBufferReferencedByComputeShader = 0x90ED,
        [Obsolete("Deprecated in favour of \"Binding\"")]
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_BINDING")]
        AtomicCounterBufferBinding = 0x92C1,
        [Obsolete("Deprecated in favour of \"DataSize\"")]
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE")]
        AtomicCounterBufferDataSize = 0x92C4,
        [Obsolete("Deprecated in favour of \"ActiveAtomicCounters\"")]
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS")]
        AtomicCounterBufferActiveAtomicCounters = 0x92C5,
        [Obsolete("Deprecated in favour of \"ActiveAtomicCounterIndices\"")]
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES")]
        AtomicCounterBufferActiveAtomicCounterIndices = 0x92C6,
        [Obsolete("Deprecated in favour of \"ReferencedByVertexShader\"")]
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER")]
        AtomicCounterBufferReferencedByVertexShader = 0x92C7,
        [Obsolete("Deprecated in favour of \"ReferencedByTessControlShader\"")]
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER")]
        AtomicCounterBufferReferencedByTessControlShader = 0x92C8,
        [Obsolete("Deprecated in favour of \"ReferencedByTessEvaluationShader\"")]
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER")]
        AtomicCounterBufferReferencedByTessEvaluationShader = 0x92C9,
        [Obsolete("Deprecated in favour of \"ReferencedByGeometryShader\"")]
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER")]
        AtomicCounterBufferReferencedByGeometryShader = 0x92CA,
        [Obsolete("Deprecated in favour of \"ReferencedByFragmentShader\"")]
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER")]
        AtomicCounterBufferReferencedByFragmentShader = 0x92CB,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_COMPUTE_SHADER")]
        ReferencedByComputeShader = 0x90ED,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_BINDING")]
        Binding = 0x92C1,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_DATA_SIZE")]
        DataSize = 0x92C4,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTERS")]
        ActiveAtomicCounters = 0x92C5,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_ACTIVE_ATOMIC_COUNTER_INDICES")]
        ActiveAtomicCounterIndices = 0x92C6,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_VERTEX_SHADER")]
        ReferencedByVertexShader = 0x92C7,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_CONTROL_SHADER")]
        ReferencedByTessControlShader = 0x92C8,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_TESS_EVALUATION_SHADER")]
        ReferencedByTessEvaluationShader = 0x92C9,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_GEOMETRY_SHADER")]
        ReferencedByGeometryShader = 0x92CA,
        [NativeName("Name", "GL_ATOMIC_COUNTER_BUFFER_REFERENCED_BY_FRAGMENT_SHADER")]
        ReferencedByFragmentShader = 0x92CB,
    }
}
