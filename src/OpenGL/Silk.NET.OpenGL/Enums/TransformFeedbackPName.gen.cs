// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    public enum TransformFeedbackPName
    {
        TransformFeedbackBufferStart = 0x8C84,
        TransformFeedbackBufferSize = 0x8C85,
        TransformFeedbackBufferBinding = 0x8C8F,
        TransformFeedbackPaused = 0x8E23,
        TransformFeedbackActive = 0x8E24,
    }
}
