// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D9
{
    [Flags]
    [NativeName("Name", "_D3DCMPFUNC")]
    public enum Cmpfunc : int
    {
        [NativeName("Name", "D3DCMP_NEVER")]
        CmpNever = 0x1,
        [NativeName("Name", "D3DCMP_LESS")]
        CmpLess = 0x2,
        [NativeName("Name", "D3DCMP_EQUAL")]
        CmpEqual = 0x3,
        [NativeName("Name", "D3DCMP_LESSEQUAL")]
        CmpLessequal = 0x4,
        [NativeName("Name", "D3DCMP_GREATER")]
        CmpGreater = 0x5,
        [NativeName("Name", "D3DCMP_NOTEQUAL")]
        CmpNotequal = 0x6,
        [NativeName("Name", "D3DCMP_GREATEREQUAL")]
        CmpGreaterequal = 0x7,
        [NativeName("Name", "D3DCMP_ALWAYS")]
        CmpAlways = 0x8,
        [NativeName("Name", "D3DCMP_FORCE_DWORD")]
        CmpForceDword = 0x7FFFFFFF,
    }
}
