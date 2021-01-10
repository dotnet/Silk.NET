// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.NOK
{
    [NativeName("Name", "GLenum")]
    public enum NOK : int
    {
        [NativeName("Name", "EGL_Y_INVERTED_NOK")]
        YInvertedNok = 0x307F,
    }
}
