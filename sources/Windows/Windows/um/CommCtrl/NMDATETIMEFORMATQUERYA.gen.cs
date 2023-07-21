// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMDATETIMEFORMATQUERYA.xml' path='doc/member[@name="NMDATETIMEFORMATQUERYA"]/*' />
public unsafe partial struct NMDATETIMEFORMATQUERYA
{
    /// <include file='NMDATETIMEFORMATQUERYA.xml' path='doc/member[@name="NMDATETIMEFORMATQUERYA.nmhdr"]/*' />
    public NMHDR nmhdr;

    /// <include file='NMDATETIMEFORMATQUERYA.xml' path='doc/member[@name="NMDATETIMEFORMATQUERYA.pszFormat"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* pszFormat;

    /// <include file='NMDATETIMEFORMATQUERYA.xml' path='doc/member[@name="NMDATETIMEFORMATQUERYA.szMax"]/*' />
    public SIZE szMax;
}
