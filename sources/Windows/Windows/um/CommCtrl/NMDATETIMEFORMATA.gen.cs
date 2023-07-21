// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMDATETIMEFORMATA.xml' path='doc/member[@name="NMDATETIMEFORMATA"]/*' />
public unsafe partial struct NMDATETIMEFORMATA
{
    /// <include file='NMDATETIMEFORMATA.xml' path='doc/member[@name="NMDATETIMEFORMATA.nmhdr"]/*' />
    public NMHDR nmhdr;

    /// <include file='NMDATETIMEFORMATA.xml' path='doc/member[@name="NMDATETIMEFORMATA.pszFormat"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* pszFormat;

    /// <include file='NMDATETIMEFORMATA.xml' path='doc/member[@name="NMDATETIMEFORMATA.st"]/*' />
    public SYSTEMTIME st;

    /// <include file='NMDATETIMEFORMATA.xml' path='doc/member[@name="NMDATETIMEFORMATA.pszDisplay"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* pszDisplay;

    /// <include file='NMDATETIMEFORMATA.xml' path='doc/member[@name="NMDATETIMEFORMATA.szDisplay"]/*' />
    [NativeTypeName("CHAR[64]")]
    public fixed sbyte szDisplay[64];
}
