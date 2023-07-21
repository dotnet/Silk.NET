// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='EMREXTSELECTCLIPRGN.xml' path='doc/member[@name="EMREXTSELECTCLIPRGN"]/*' />
public unsafe partial struct EMREXTSELECTCLIPRGN
{
    /// <include file='EMREXTSELECTCLIPRGN.xml' path='doc/member[@name="EMREXTSELECTCLIPRGN.emr"]/*' />
    public EMR emr;

    /// <include file='EMREXTSELECTCLIPRGN.xml' path='doc/member[@name="EMREXTSELECTCLIPRGN.cbRgnData"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbRgnData;

    /// <include file='EMREXTSELECTCLIPRGN.xml' path='doc/member[@name="EMREXTSELECTCLIPRGN.iMode"]/*' />
    [NativeTypeName("DWORD")]
    public uint iMode;

    /// <include file='EMREXTSELECTCLIPRGN.xml' path='doc/member[@name="EMREXTSELECTCLIPRGN.RgnData"]/*' />
    [NativeTypeName("BYTE[1]")]
    public fixed byte RgnData[1];
}
