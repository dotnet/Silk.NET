// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiBlendMode")]
    public enum BlendMode : int
    {
        [NativeName("Name", "aiBlendMode_Default")]
        BlendModeDefault = 0x0,
        [NativeName("Name", "aiBlendMode_Additive")]
        BlendModeAdditive = 0x1,
    }
}
