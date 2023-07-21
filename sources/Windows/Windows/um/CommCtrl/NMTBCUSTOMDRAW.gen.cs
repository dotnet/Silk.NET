// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NMTBCUSTOMDRAW.xml' path='doc/member[@name="NMTBCUSTOMDRAW"]/*' />
public partial struct NMTBCUSTOMDRAW
{
    /// <include file='NMTBCUSTOMDRAW.xml' path='doc/member[@name="NMTBCUSTOMDRAW.nmcd"]/*' />
    public NMCUSTOMDRAW nmcd;

    /// <include file='NMTBCUSTOMDRAW.xml' path='doc/member[@name="NMTBCUSTOMDRAW.hbrMonoDither"]/*' />
    public HBRUSH hbrMonoDither;

    /// <include file='NMTBCUSTOMDRAW.xml' path='doc/member[@name="NMTBCUSTOMDRAW.hbrLines"]/*' />
    public HBRUSH hbrLines;

    /// <include file='NMTBCUSTOMDRAW.xml' path='doc/member[@name="NMTBCUSTOMDRAW.hpenLines"]/*' />
    public HPEN hpenLines;

    /// <include file='NMTBCUSTOMDRAW.xml' path='doc/member[@name="NMTBCUSTOMDRAW.clrText"]/*' />
    public COLORREF clrText;

    /// <include file='NMTBCUSTOMDRAW.xml' path='doc/member[@name="NMTBCUSTOMDRAW.clrMark"]/*' />
    public COLORREF clrMark;

    /// <include file='NMTBCUSTOMDRAW.xml' path='doc/member[@name="NMTBCUSTOMDRAW.clrTextHighlight"]/*' />
    public COLORREF clrTextHighlight;

    /// <include file='NMTBCUSTOMDRAW.xml' path='doc/member[@name="NMTBCUSTOMDRAW.clrBtnFace"]/*' />
    public COLORREF clrBtnFace;

    /// <include file='NMTBCUSTOMDRAW.xml' path='doc/member[@name="NMTBCUSTOMDRAW.clrBtnHighlight"]/*' />
    public COLORREF clrBtnHighlight;

    /// <include file='NMTBCUSTOMDRAW.xml' path='doc/member[@name="NMTBCUSTOMDRAW.clrHighlightHotTrack"]/*' />
    public COLORREF clrHighlightHotTrack;

    /// <include file='NMTBCUSTOMDRAW.xml' path='doc/member[@name="NMTBCUSTOMDRAW.rcText"]/*' />
    public RECT rcText;

    /// <include file='NMTBCUSTOMDRAW.xml' path='doc/member[@name="NMTBCUSTOMDRAW.nStringBkMode"]/*' />
    public int nStringBkMode;

    /// <include file='NMTBCUSTOMDRAW.xml' path='doc/member[@name="NMTBCUSTOMDRAW.nHLStringBkMode"]/*' />
    public int nHLStringBkMode;

    /// <include file='NMTBCUSTOMDRAW.xml' path='doc/member[@name="NMTBCUSTOMDRAW.iListGap"]/*' />
    public int iListGap;
}
