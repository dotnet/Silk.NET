// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TVGETITEMPARTRECTINFO.xml' path='doc/member[@name="TVGETITEMPARTRECTINFO"]/*' />
public unsafe partial struct TVGETITEMPARTRECTINFO
{
    /// <include file='TVGETITEMPARTRECTINFO.xml' path='doc/member[@name="TVGETITEMPARTRECTINFO.hti"]/*' />
    public HTREEITEM hti;

    /// <include file='TVGETITEMPARTRECTINFO.xml' path='doc/member[@name="TVGETITEMPARTRECTINFO.prc"]/*' />
    public RECT* prc;

    /// <include file='TVGETITEMPARTRECTINFO.xml' path='doc/member[@name="TVGETITEMPARTRECTINFO.partID"]/*' />
    public TVITEMPART partID;
}
