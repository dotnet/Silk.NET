// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MCHITTESTINFO.xml' path='doc/member[@name="MCHITTESTINFO"]/*' />
public partial struct MCHITTESTINFO
{
    /// <include file='MCHITTESTINFO.xml' path='doc/member[@name="MCHITTESTINFO.cbSize"]/*' />
    public uint cbSize;

    /// <include file='MCHITTESTINFO.xml' path='doc/member[@name="MCHITTESTINFO.pt"]/*' />
    public POINT pt;

    /// <include file='MCHITTESTINFO.xml' path='doc/member[@name="MCHITTESTINFO.uHit"]/*' />
    public uint uHit;

    /// <include file='MCHITTESTINFO.xml' path='doc/member[@name="MCHITTESTINFO.st"]/*' />
    public SYSTEMTIME st;

    /// <include file='MCHITTESTINFO.xml' path='doc/member[@name="MCHITTESTINFO.rc"]/*' />
    public RECT rc;

    /// <include file='MCHITTESTINFO.xml' path='doc/member[@name="MCHITTESTINFO.iOffset"]/*' />
    public int iOffset;

    /// <include file='MCHITTESTINFO.xml' path='doc/member[@name="MCHITTESTINFO.iRow"]/*' />
    public int iRow;

    /// <include file='MCHITTESTINFO.xml' path='doc/member[@name="MCHITTESTINFO.iCol"]/*' />
    public int iCol;
}
