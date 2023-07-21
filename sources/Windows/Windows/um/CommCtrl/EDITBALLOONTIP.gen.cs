// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='EDITBALLOONTIP.xml' path='doc/member[@name="EDITBALLOONTIP"]/*' />
public unsafe partial struct EDITBALLOONTIP
{
    /// <include file='EDITBALLOONTIP.xml' path='doc/member[@name="EDITBALLOONTIP.cbStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    /// <include file='EDITBALLOONTIP.xml' path='doc/member[@name="EDITBALLOONTIP.pszTitle"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* pszTitle;

    /// <include file='EDITBALLOONTIP.xml' path='doc/member[@name="EDITBALLOONTIP.pszText"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* pszText;

    /// <include file='EDITBALLOONTIP.xml' path='doc/member[@name="EDITBALLOONTIP.ttiIcon"]/*' />
    public int ttiIcon;
}
