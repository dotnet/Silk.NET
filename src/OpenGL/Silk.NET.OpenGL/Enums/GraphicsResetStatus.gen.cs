// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    public enum GraphicsResetStatus
    {
        NoError = 0x0,
        GuiltyContextReset = 0x8253,
        InnocentContextReset = 0x8254,
        UnknownContextReset = 0x8255,
    }
}
