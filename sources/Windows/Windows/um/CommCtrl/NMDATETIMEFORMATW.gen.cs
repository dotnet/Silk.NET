// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMDATETIMEFORMATW.xml' path='doc/member[@name="NMDATETIMEFORMATW"]/*' />
public unsafe partial struct NMDATETIMEFORMATW
{
    /// <include file='NMDATETIMEFORMATW.xml' path='doc/member[@name="NMDATETIMEFORMATW.nmhdr"]/*' />
    public NMHDR nmhdr;

    /// <include file='NMDATETIMEFORMATW.xml' path='doc/member[@name="NMDATETIMEFORMATW.pszFormat"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* pszFormat;

    /// <include file='NMDATETIMEFORMATW.xml' path='doc/member[@name="NMDATETIMEFORMATW.st"]/*' />
    public SYSTEMTIME st;

    /// <include file='NMDATETIMEFORMATW.xml' path='doc/member[@name="NMDATETIMEFORMATW.pszDisplay"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* pszDisplay;

    /// <include file='NMDATETIMEFORMATW.xml' path='doc/member[@name="NMDATETIMEFORMATW.szDisplay"]/*' />
    [NativeTypeName("WCHAR[64]")]
    public fixed ushort szDisplay[64];
}
