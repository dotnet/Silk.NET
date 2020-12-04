// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "DataTypeEXT")]
    public enum DataTypeEXT
    {
        [NativeName("Name", "GL_SCALAR_EXT")]
        ScalarExt = 0x87BE,
        [NativeName("Name", "GL_VECTOR_EXT")]
        VectorExt = 0x87BF,
        [NativeName("Name", "GL_MATRIX_EXT")]
        MatrixExt = 0x87C0,
    }
}
