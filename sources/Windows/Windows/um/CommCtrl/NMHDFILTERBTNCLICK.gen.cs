// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMHDFILTERBTNCLICK.xml' path='doc/member[@name="NMHDFILTERBTNCLICK"]/*' />
public partial struct NMHDFILTERBTNCLICK
{
    /// <include file='NMHDFILTERBTNCLICK.xml' path='doc/member[@name="NMHDFILTERBTNCLICK.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMHDFILTERBTNCLICK.xml' path='doc/member[@name="NMHDFILTERBTNCLICK.iItem"]/*' />
    public int iItem;

    /// <include file='NMHDFILTERBTNCLICK.xml' path='doc/member[@name="NMHDFILTERBTNCLICK.rc"]/*' />
    public RECT rc;
}
