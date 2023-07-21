// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMVIEWCHANGE.xml' path='doc/member[@name="NMVIEWCHANGE"]/*' />
public partial struct NMVIEWCHANGE
{
    /// <include file='NMVIEWCHANGE.xml' path='doc/member[@name="NMVIEWCHANGE.nmhdr"]/*' />
    public NMHDR nmhdr;

    /// <include file='NMVIEWCHANGE.xml' path='doc/member[@name="NMVIEWCHANGE.dwOldView"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwOldView;

    /// <include file='NMVIEWCHANGE.xml' path='doc/member[@name="NMVIEWCHANGE.dwNewView"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwNewView;
}
