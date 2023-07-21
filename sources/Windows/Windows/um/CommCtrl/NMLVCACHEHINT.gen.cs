// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMLVCACHEHINT.xml' path='doc/member[@name="NMLVCACHEHINT"]/*' />
public partial struct NMLVCACHEHINT
{
    /// <include file='NMLVCACHEHINT.xml' path='doc/member[@name="NMLVCACHEHINT.hdr"]/*' />
    public NMHDR hdr;

    /// <include file='NMLVCACHEHINT.xml' path='doc/member[@name="NMLVCACHEHINT.iFrom"]/*' />
    public int iFrom;

    /// <include file='NMLVCACHEHINT.xml' path='doc/member[@name="NMLVCACHEHINT.iTo"]/*' />
    public int iTo;
}
