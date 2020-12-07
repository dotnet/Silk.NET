// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "GetTexBumpParameterATI")]
    public enum GetTexBumpParameterATI
    {
        [NativeName("Name", "GL_BUMP_ROT_MATRIX_ATI")]
        BumpRotMatrixAti = 0x8775,
        [NativeName("Name", "GL_BUMP_ROT_MATRIX_SIZE_ATI")]
        BumpRotMatrixSizeAti = 0x8776,
        [NativeName("Name", "GL_BUMP_NUM_TEX_UNITS_ATI")]
        BumpNumTexUnitsAti = 0x8777,
        [NativeName("Name", "GL_BUMP_TEX_UNITS_ATI")]
        BumpTexUnitsAti = 0x8778,
    }
}
