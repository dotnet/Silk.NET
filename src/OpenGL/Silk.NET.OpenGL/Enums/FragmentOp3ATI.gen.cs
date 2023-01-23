// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "FragmentOp3ATI")]
    public enum FragmentOp3ATI : int
    {
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
