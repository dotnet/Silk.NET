// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMREBAR.xml' path='doc/member[@name="NMREBAR"]/*' />
public partial struct NMREBAR
{
    /// <include file='NMREBAR.xml' path='doc/member[@name="NMREBAR.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMREBAR.xml' path='doc/member[@name="NMREBAR.dwMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMask;

    /// <include file='NMREBAR.xml' path='doc/member[@name="NMREBAR.uBand"]/*' />
    public uint uBand;

    /// <include file='NMREBAR.xml' path='doc/member[@name="NMREBAR.fStyle"]/*' />
    public uint fStyle;

    /// <include file='NMREBAR.xml' path='doc/member[@name="NMREBAR.wID"]/*' />
    public uint wID;

    /// <include file='NMREBAR.xml' path='doc/member[@name="NMREBAR.lParam"]/*' />
    public LPARAM lParam;
}
