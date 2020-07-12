// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "AtomicCounterBufferPName")]
    public enum AtomicCounterBufferPName
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
