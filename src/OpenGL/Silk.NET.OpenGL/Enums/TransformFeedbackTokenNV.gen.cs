// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "TransformFeedbackTokenNV")]
    public enum TransformFeedbackTokenNV
    {
        [NativeName("Name", "GL_NEXT_BUFFER_NV")]
        NextBufferNV = unchecked((int)0xFFFFFFFFFFFFFFFE),
        [NativeName("Name", "GL_SKIP_COMPONENTS4_NV")]
        SkipComponents4NV = unchecked((int)0xFFFFFFFFFFFFFFFD),
        [NativeName("Name", "GL_SKIP_COMPONENTS3_NV")]
        SkipComponents3NV = unchecked((int)0xFFFFFFFFFFFFFFFC),
        [NativeName("Name", "GL_SKIP_COMPONENTS2_NV")]
        SkipComponents2NV = unchecked((int)0xFFFFFFFFFFFFFFFB),
        [NativeName("Name", "GL_SKIP_COMPONENTS1_NV")]
        SkipComponents1NV = unchecked((int)0xFFFFFFFFFFFFFFFA),
    }
}
