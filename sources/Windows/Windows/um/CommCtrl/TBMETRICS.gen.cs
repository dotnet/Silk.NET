// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TBMETRICS.xml' path='doc/member[@name="TBMETRICS"]/*' />
public partial struct TBMETRICS
{
    /// <include file='TBMETRICS.xml' path='doc/member[@name="TBMETRICS.cbSize"]/*' />
    public uint cbSize;

    /// <include file='TBMETRICS.xml' path='doc/member[@name="TBMETRICS.dwMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMask;

    /// <include file='TBMETRICS.xml' path='doc/member[@name="TBMETRICS.cxPad"]/*' />
    public int cxPad;

    /// <include file='TBMETRICS.xml' path='doc/member[@name="TBMETRICS.cyPad"]/*' />
    public int cyPad;

    /// <include file='TBMETRICS.xml' path='doc/member[@name="TBMETRICS.cxBarPad"]/*' />
    public int cxBarPad;

    /// <include file='TBMETRICS.xml' path='doc/member[@name="TBMETRICS.cyBarPad"]/*' />
    public int cyBarPad;

    /// <include file='TBMETRICS.xml' path='doc/member[@name="TBMETRICS.cxButtonSpacing"]/*' />
    public int cxButtonSpacing;

    /// <include file='TBMETRICS.xml' path='doc/member[@name="TBMETRICS.cyButtonSpacing"]/*' />
    public int cyButtonSpacing;
}
