// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    public enum GetPointervPName
    {
        FeedbackBufferPointer = 0xDF0,
        SelectionBufferPointer = 0xDF3,
        VertexArrayPointer = 0x808E,
        VertexArrayPointerExt = 0x808E,
        NormalArrayPointer = 0x808F,
        NormalArrayPointerExt = 0x808F,
        ColorArrayPointer = 0x8090,
        ColorArrayPointerExt = 0x8090,
        IndexArrayPointer = 0x8091,
        IndexArrayPointerExt = 0x8091,
        TextureCoordArrayPointer = 0x8092,
        TextureCoordArrayPointerExt = 0x8092,
        EdgeFlagArrayPointer = 0x8093,
        EdgeFlagArrayPointerExt = 0x8093,
        InstrumentBufferPointerSgix = 0x8180,
        DebugCallbackFunction = 0x8244,
        DebugCallbackUserParam = 0x8245,
    }
}
