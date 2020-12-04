// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "PreserveModeATI")]
    public enum PreserveModeATI
    {
        [NativeName("Name", "GL_PRESERVE_ATI")]
        PreserveAti = 0x8762,
        [NativeName("Name", "GL_DISCARD_ATI")]
        DiscardAti = 0x8763,
    }
}
