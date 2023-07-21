// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='LVFOOTERINFO.xml' path='doc/member[@name="LVFOOTERINFO"]/*' />
public unsafe partial struct LVFOOTERINFO
{
    /// <include file='LVFOOTERINFO.xml' path='doc/member[@name="LVFOOTERINFO.mask"]/*' />
    public uint mask;

    /// <include file='LVFOOTERINFO.xml' path='doc/member[@name="LVFOOTERINFO.pszText"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pszText;

    /// <include file='LVFOOTERINFO.xml' path='doc/member[@name="LVFOOTERINFO.cchTextMax"]/*' />
    public int cchTextMax;

    /// <include file='LVFOOTERINFO.xml' path='doc/member[@name="LVFOOTERINFO.cItems"]/*' />
    public uint cItems;
}
