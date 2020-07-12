// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "MapQuery")]
    public enum MapQuery
    {
        [NativeName("Name", "GL_COEFF")]
        Coeff = 0xA00,
        [NativeName("Name", "GL_ORDER")]
        Order = 0xA01,
        [NativeName("Name", "GL_DOMAIN")]
        Domain = 0xA02,
    }
}
