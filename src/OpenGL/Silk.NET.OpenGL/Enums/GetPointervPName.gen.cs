// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    public enum GetPointervPName
    {
        VertexArrayPointerExt = 0x808E,
        NormalArrayPointerExt = 0x808F,
        ColorArrayPointerExt = 0x8090,
        IndexArrayPointerExt = 0x8091,
        TextureCoordArrayPointerExt = 0x8092,
        EdgeFlagArrayPointerExt = 0x8093,
        InstrumentBufferPointerSgix = 0x8180,
        DebugCallbackFunction = 0x8244,
        DebugCallbackUserParam = 0x8245,
    }
}
