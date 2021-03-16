// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "VariantCapEXT")]
    public enum VariantCapEXT : int
    {
        [NativeName("Name", "GL_VARIANT_ARRAY_EXT")]
        VariantArrayExt = 0x87E8,
    }
}
