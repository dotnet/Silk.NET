// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    public enum StencilOp
    {
        Zero = 0x0,
        Invert = 0x150A,
        Keep = 0x1E00,
        Replace = 0x1E01,
        Incr = 0x1E02,
        Decr = 0x1E03,
        IncrWrap = 0x8507,
        DecrWrap = 0x8508,
    }
}
