// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "FragmentOp2ATI")]
    public enum FragmentOp2ATI : int
    {
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
    }
}
