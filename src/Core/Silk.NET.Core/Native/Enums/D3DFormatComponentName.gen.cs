// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    [NativeName("Name", "D3D_FORMAT_COMPONENT_NAME")]
    public enum D3DFormatComponentName : int
    {
        [Obsolete("Deprecated in favour of \"R\"")]
        [NativeName("Name", "D3DFCN_R")]
        D3DfcnR = unchecked((int) 0xFFFFFFFFFFFFFFFC),
        [Obsolete("Deprecated in favour of \"G\"")]
        [NativeName("Name", "D3DFCN_G")]
        D3DfcnG = unchecked((int) 0xFFFFFFFFFFFFFFFD),
        [Obsolete("Deprecated in favour of \"B\"")]
        [NativeName("Name", "D3DFCN_B")]
        D3DfcnB = unchecked((int) 0xFFFFFFFFFFFFFFFE),
        [Obsolete("Deprecated in favour of \"A\"")]
        [NativeName("Name", "D3DFCN_A")]
        D3DfcnA = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [Obsolete("Deprecated in favour of \"D\"")]
        [NativeName("Name", "D3DFCN_D")]
        D3DfcnD = 0x0,
        [Obsolete("Deprecated in favour of \"S\"")]
        [NativeName("Name", "D3DFCN_S")]
        D3DfcnS = 0x1,
        [Obsolete("Deprecated in favour of \"X\"")]
        [NativeName("Name", "D3DFCN_X")]
        D3DfcnX = 0x2,
        [NativeName("Name", "D3DFCN_R")]
        R = unchecked((int) 0xFFFFFFFFFFFFFFFC),
        [NativeName("Name", "D3DFCN_G")]
        G = unchecked((int) 0xFFFFFFFFFFFFFFFD),
        [NativeName("Name", "D3DFCN_B")]
        B = unchecked((int) 0xFFFFFFFFFFFFFFFE),
        [NativeName("Name", "D3DFCN_A")]
        A = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D3DFCN_D")]
        D = 0x0,
        [NativeName("Name", "D3DFCN_S")]
        S = 0x1,
        [NativeName("Name", "D3DFCN_X")]
        X = 0x2,
    }
}
