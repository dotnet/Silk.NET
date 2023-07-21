// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TCITEMHEADERW.xml' path='doc/member[@name="TCITEMHEADERW"]/*' />
public unsafe partial struct TCITEMHEADERW
{
    /// <include file='TCITEMHEADERW.xml' path='doc/member[@name="TCITEMHEADERW.mask"]/*' />
    public uint mask;

    /// <include file='TCITEMHEADERW.xml' path='doc/member[@name="TCITEMHEADERW.lpReserved1"]/*' />
    public uint lpReserved1;

    /// <include file='TCITEMHEADERW.xml' path='doc/member[@name="TCITEMHEADERW.lpReserved2"]/*' />
    public uint lpReserved2;

    /// <include file='TCITEMHEADERW.xml' path='doc/member[@name="TCITEMHEADERW.pszText"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszText;

    /// <include file='TCITEMHEADERW.xml' path='doc/member[@name="TCITEMHEADERW.cchTextMax"]/*' />
    public int cchTextMax;

    /// <include file='TCITEMHEADERW.xml' path='doc/member[@name="TCITEMHEADERW.iImage"]/*' />
    public int iImage;
}
