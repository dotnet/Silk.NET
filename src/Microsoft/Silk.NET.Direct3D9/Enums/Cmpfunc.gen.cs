// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DCMPFUNC")]
    public enum Cmpfunc : int
    {
        [Obsolete("Deprecated in favour of \"Never\"")]
        [NativeName("Name", "D3DCMP_NEVER")]
        CmpNever = 0x1,
        [Obsolete("Deprecated in favour of \"Less\"")]
        [NativeName("Name", "D3DCMP_LESS")]
        CmpLess = 0x2,
        [Obsolete("Deprecated in favour of \"Equal\"")]
        [NativeName("Name", "D3DCMP_EQUAL")]
        CmpEqual = 0x3,
        [Obsolete("Deprecated in favour of \"Lessequal\"")]
        [NativeName("Name", "D3DCMP_LESSEQUAL")]
        CmpLessequal = 0x4,
        [Obsolete("Deprecated in favour of \"Greater\"")]
        [NativeName("Name", "D3DCMP_GREATER")]
        CmpGreater = 0x5,
        [Obsolete("Deprecated in favour of \"Notequal\"")]
        [NativeName("Name", "D3DCMP_NOTEQUAL")]
        CmpNotequal = 0x6,
        [Obsolete("Deprecated in favour of \"Greaterequal\"")]
        [NativeName("Name", "D3DCMP_GREATEREQUAL")]
        CmpGreaterequal = 0x7,
        [Obsolete("Deprecated in favour of \"Always\"")]
        [NativeName("Name", "D3DCMP_ALWAYS")]
        CmpAlways = 0x8,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D3DCMP_FORCE_DWORD")]
        CmpForceDword = 0x7FFFFFFF,
        [NativeName("Name", "D3DCMP_NEVER")]
        Never = 0x1,
        [NativeName("Name", "D3DCMP_LESS")]
        Less = 0x2,
        [NativeName("Name", "D3DCMP_EQUAL")]
        Equal = 0x3,
        [NativeName("Name", "D3DCMP_LESSEQUAL")]
        Lessequal = 0x4,
        [NativeName("Name", "D3DCMP_GREATER")]
        Greater = 0x5,
        [NativeName("Name", "D3DCMP_NOTEQUAL")]
        Notequal = 0x6,
        [NativeName("Name", "D3DCMP_GREATEREQUAL")]
        Greaterequal = 0x7,
        [NativeName("Name", "D3DCMP_ALWAYS")]
        Always = 0x8,
        [NativeName("Name", "D3DCMP_FORCE_DWORD")]
        ForceDword = 0x7FFFFFFF,
    }
}
