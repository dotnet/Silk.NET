// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;

namespace Silk.NET.OpenGLES
{
    public enum ConditionalRenderMode
    {
        QueryWait = 0x8E13,
        QueryNoWait = 0x8E14,
        QueryByRegionWait = 0x8E15,
        QueryByRegionNoWait = 0x8E16,
        QueryWaitInverted = 0x8E17,
        QueryNoWaitInverted = 0x8E18,
        QueryByRegionWaitInverted = 0x8E19,
        QueryByRegionNoWaitInverted = 0x8E1A,
    }
}
