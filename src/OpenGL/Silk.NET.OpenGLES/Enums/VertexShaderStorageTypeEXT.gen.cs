// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "VertexShaderStorageTypeEXT")]
    public enum VertexShaderStorageTypeEXT
    {
        [NativeName("Name", "GL_VARIANT_EXT")]
        VariantExt = 0x87C1,
        [NativeName("Name", "GL_INVARIANT_EXT")]
        InvariantExt = 0x87C2,
        [NativeName("Name", "GL_LOCAL_CONSTANT_EXT")]
        LocalConstantExt = 0x87C3,
        [NativeName("Name", "GL_LOCAL_EXT")]
        LocalExt = 0x87C4,
    }
}
