// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    public enum QueryTarget
    {
        TransformFeedbackOverflow = 0x82EC,
        VerticesSubmitted = 0x82EE,
        PrimitivesSubmitted = 0x82EF,
        VertexShaderInvocations = 0x82F0,
        TimeElapsed = 0x88BF,
        SamplesPassed = 0x8914,
        AnySamplesPassed = 0x8C2F,
        PrimitivesGenerated = 0x8C87,
        TransformFeedbackPrimitivesWritten = 0x8C88,
        AnySamplesPassedConservative = 0x8D6A,
    }
}
