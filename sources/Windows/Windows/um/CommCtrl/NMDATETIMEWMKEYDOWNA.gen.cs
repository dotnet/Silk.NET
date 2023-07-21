// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMDATETIMEWMKEYDOWNA.xml' path='doc/member[@name="NMDATETIMEWMKEYDOWNA"]/*' />
public unsafe partial struct NMDATETIMEWMKEYDOWNA
{
    /// <include file='NMDATETIMEWMKEYDOWNA.xml' path='doc/member[@name="NMDATETIMEWMKEYDOWNA.nmhdr"]/*' />
    public NMHDR nmhdr;

    /// <include file='NMDATETIMEWMKEYDOWNA.xml' path='doc/member[@name="NMDATETIMEWMKEYDOWNA.nVirtKey"]/*' />
    public int nVirtKey;

    /// <include file='NMDATETIMEWMKEYDOWNA.xml' path='doc/member[@name="NMDATETIMEWMKEYDOWNA.pszFormat"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* pszFormat;

    /// <include file='NMDATETIMEWMKEYDOWNA.xml' path='doc/member[@name="NMDATETIMEWMKEYDOWNA.st"]/*' />
    public SYSTEMTIME st;
}
