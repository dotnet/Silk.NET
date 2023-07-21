// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace Silk.NET.Windows;

/// <include file='PRINTFLAG.xml' path='doc/member[@name="PRINTFLAG"]/*' />
[Flags]
public enum PRINTFLAG
{
    /// <include file='PRINTFLAG.xml' path='doc/member[@name="PRINTFLAG.PRINTFLAG_MAYBOTHERUSER"]/*' />
    PRINTFLAG_MAYBOTHERUSER = 1,

    /// <include file='PRINTFLAG.xml' path='doc/member[@name="PRINTFLAG.PRINTFLAG_PROMPTUSER"]/*' />
    PRINTFLAG_PROMPTUSER = 2,

    /// <include file='PRINTFLAG.xml' path='doc/member[@name="PRINTFLAG.PRINTFLAG_USERMAYCHANGEPRINTER"]/*' />
    PRINTFLAG_USERMAYCHANGEPRINTER = 4,

    /// <include file='PRINTFLAG.xml' path='doc/member[@name="PRINTFLAG.PRINTFLAG_RECOMPOSETODEVICE"]/*' />
    PRINTFLAG_RECOMPOSETODEVICE = 8,

    /// <include file='PRINTFLAG.xml' path='doc/member[@name="PRINTFLAG.PRINTFLAG_DONTACTUALLYPRINT"]/*' />
    PRINTFLAG_DONTACTUALLYPRINT = 16,

    /// <include file='PRINTFLAG.xml' path='doc/member[@name="PRINTFLAG.PRINTFLAG_FORCEPROPERTIES"]/*' />
    PRINTFLAG_FORCEPROPERTIES = 32,

    /// <include file='PRINTFLAG.xml' path='doc/member[@name="PRINTFLAG.PRINTFLAG_PRINTTOFILE"]/*' />
    PRINTFLAG_PRINTTOFILE = 64,
}
