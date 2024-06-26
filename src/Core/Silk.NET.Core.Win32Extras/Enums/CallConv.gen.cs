// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagCALLCONV")]
    public enum CallConv : int
    {
        [Obsolete("Deprecated in favour of \"Fastcall\"")]
        [NativeName("Name", "CC_FASTCALL")]
        CCFastcall = 0x0,
        [Obsolete("Deprecated in favour of \"Cdecl\"")]
        [NativeName("Name", "CC_CDECL")]
        CCCdecl = 0x1,
        [Obsolete("Deprecated in favour of \"Mscpascal\"")]
        [NativeName("Name", "CC_MSCPASCAL")]
        CCMscpascal = 0x2,
        [Obsolete("Deprecated in favour of \"Pascal\"")]
        [NativeName("Name", "CC_PASCAL")]
        CCPascal = 0x2,
        [Obsolete("Deprecated in favour of \"Macpascal\"")]
        [NativeName("Name", "CC_MACPASCAL")]
        CCMacpascal = 0x3,
        [Obsolete("Deprecated in favour of \"Stdcall\"")]
        [NativeName("Name", "CC_STDCALL")]
        CCStdcall = 0x4,
        [Obsolete("Deprecated in favour of \"Fpfastcall\"")]
        [NativeName("Name", "CC_FPFASTCALL")]
        CCFpfastcall = 0x5,
        [Obsolete("Deprecated in favour of \"Syscall\"")]
        [NativeName("Name", "CC_SYSCALL")]
        CCSyscall = 0x6,
        [Obsolete("Deprecated in favour of \"Mpwcdecl\"")]
        [NativeName("Name", "CC_MPWCDECL")]
        CCMpwcdecl = 0x7,
        [Obsolete("Deprecated in favour of \"Mpwpascal\"")]
        [NativeName("Name", "CC_MPWPASCAL")]
        CCMpwpascal = 0x8,
        [Obsolete("Deprecated in favour of \"Max\"")]
        [NativeName("Name", "CC_MAX")]
        CCMax = 0x9,
        [NativeName("Name", "CC_FASTCALL")]
        Fastcall = 0x0,
        [NativeName("Name", "CC_CDECL")]
        Cdecl = 0x1,
        [NativeName("Name", "CC_MSCPASCAL")]
        Mscpascal = 0x2,
        [NativeName("Name", "CC_PASCAL")]
        Pascal = 0x2,
        [NativeName("Name", "CC_MACPASCAL")]
        Macpascal = 0x3,
        [NativeName("Name", "CC_STDCALL")]
        Stdcall = 0x4,
        [NativeName("Name", "CC_FPFASTCALL")]
        Fpfastcall = 0x5,
        [NativeName("Name", "CC_SYSCALL")]
        Syscall = 0x6,
        [NativeName("Name", "CC_MPWCDECL")]
        Mpwcdecl = 0x7,
        [NativeName("Name", "CC_MPWPASCAL")]
        Mpwpascal = 0x8,
        [NativeName("Name", "CC_MAX")]
        Max = 0x9,
    }
}
