// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='LVTILEVIEWINFO.xml' path='doc/member[@name="LVTILEVIEWINFO"]/*' />
public partial struct LVTILEVIEWINFO
{
    /// <include file='LVTILEVIEWINFO.xml' path='doc/member[@name="LVTILEVIEWINFO.cbSize"]/*' />
    public uint cbSize;

    /// <include file='LVTILEVIEWINFO.xml' path='doc/member[@name="LVTILEVIEWINFO.dwMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMask;

    /// <include file='LVTILEVIEWINFO.xml' path='doc/member[@name="LVTILEVIEWINFO.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='LVTILEVIEWINFO.xml' path='doc/member[@name="LVTILEVIEWINFO.sizeTile"]/*' />
    public SIZE sizeTile;

    /// <include file='LVTILEVIEWINFO.xml' path='doc/member[@name="LVTILEVIEWINFO.cLines"]/*' />
    public int cLines;

    /// <include file='LVTILEVIEWINFO.xml' path='doc/member[@name="LVTILEVIEWINFO.rcLabelMargin"]/*' />
    public RECT rcLabelMargin;
}
