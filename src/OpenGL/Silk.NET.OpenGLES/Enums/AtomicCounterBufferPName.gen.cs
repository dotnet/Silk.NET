// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    public enum AtomicCounterBufferPName
    {
        AtomicCounterBufferReferencedByComputeShader = 0x90ED,
        AtomicCounterBufferBinding = 0x92C1,
        AtomicCounterBufferDataSize = 0x92C4,
        AtomicCounterBufferActiveAtomicCounters = 0x92C5,
        AtomicCounterBufferActiveAtomicCounterIndices = 0x92C6,
        AtomicCounterBufferReferencedByVertexShader = 0x92C7,
        AtomicCounterBufferReferencedByTessControlShader = 0x92C8,
        AtomicCounterBufferReferencedByTessEvaluationShader = 0x92C9,
        AtomicCounterBufferReferencedByGeometryShader = 0x92CA,
        AtomicCounterBufferReferencedByFragmentShader = 0x92CB,
    }
}
