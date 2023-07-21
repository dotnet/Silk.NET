// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW"]/*' />
public partial struct NONCLIENTMETRICSW
{
    /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.cbSize"]/*' />
    public uint cbSize;

    /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.iBorderWidth"]/*' />
    public int iBorderWidth;

    /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.iScrollWidth"]/*' />
    public int iScrollWidth;

    /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.iScrollHeight"]/*' />
    public int iScrollHeight;

    /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.iCaptionWidth"]/*' />
    public int iCaptionWidth;

    /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.iCaptionHeight"]/*' />
    public int iCaptionHeight;

    /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.lfCaptionFont"]/*' />
    public LOGFONTW lfCaptionFont;

    /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.iSmCaptionWidth"]/*' />
    public int iSmCaptionWidth;

    /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.iSmCaptionHeight"]/*' />
    public int iSmCaptionHeight;

    /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.lfSmCaptionFont"]/*' />
    public LOGFONTW lfSmCaptionFont;

    /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.iMenuWidth"]/*' />
    public int iMenuWidth;

    /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.iMenuHeight"]/*' />
    public int iMenuHeight;

    /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.lfMenuFont"]/*' />
    public LOGFONTW lfMenuFont;

    /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.lfStatusFont"]/*' />
    public LOGFONTW lfStatusFont;

    /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.lfMessageFont"]/*' />
    public LOGFONTW lfMessageFont;

    /// <include file='NONCLIENTMETRICSW.xml' path='doc/member[@name="NONCLIENTMETRICSW.iPaddedBorderWidth"]/*' />
    public int iPaddedBorderWidth;
}
