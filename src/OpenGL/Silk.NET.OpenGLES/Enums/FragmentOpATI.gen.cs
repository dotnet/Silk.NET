// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "FragmentOpATI")]
    public enum FragmentOpATI : int
    {
        [NativeName("Name", "GL_MOV_ATI")]
        MovAti = 0x8961,
        [NativeName("Name", "GL_ADD_ATI")]
        AddAti = 0x8963,
        [NativeName("Name", "GL_MUL_ATI")]
        MulAti = 0x8964,
        [NativeName("Name", "GL_SUB_ATI")]
        SubAti = 0x8965,
        [NativeName("Name", "GL_DOT3_ATI")]
        Dot3Ati = 0x8966,
        [NativeName("Name", "GL_DOT4_ATI")]
        Dot4Ati = 0x8967,
        [NativeName("Name", "GL_MAD_ATI")]
        MadAti = 0x8968,
        [NativeName("Name", "GL_LERP_ATI")]
        LerpAti = 0x8969,
        [NativeName("Name", "GL_CND_ATI")]
        CndAti = 0x896A,
        [NativeName("Name", "GL_CND0_ATI")]
        Cnd0Ati = 0x896B,
        [NativeName("Name", "GL_DOT2_ADD_ATI")]
        Dot2AddAti = 0x896C,
    }
}
