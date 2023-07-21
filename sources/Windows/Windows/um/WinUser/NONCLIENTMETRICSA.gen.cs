// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='NONCLIENTMETRICSA.xml' path='doc/member[@name="NONCLIENTMETRICSA"]/*' />
public partial struct NONCLIENTMETRICSA
{
    /// <include file='NONCLIENTMETRICSA.xml' path='doc/member[@name="NONCLIENTMETRICSA.cbSize"]/*' />
    public uint cbSize;

    /// <include file='NONCLIENTMETRICSA.xml' path='doc/member[@name="NONCLIENTMETRICSA.iBorderWidth"]/*' />
    public int iBorderWidth;

    /// <include file='NONCLIENTMETRICSA.xml' path='doc/member[@name="NONCLIENTMETRICSA.iScrollWidth"]/*' />
    public int iScrollWidth;

    /// <include file='NONCLIENTMETRICSA.xml' path='doc/member[@name="NONCLIENTMETRICSA.iScrollHeight"]/*' />
    public int iScrollHeight;

    /// <include file='NONCLIENTMETRICSA.xml' path='doc/member[@name="NONCLIENTMETRICSA.iCaptionWidth"]/*' />
    public int iCaptionWidth;

    /// <include file='NONCLIENTMETRICSA.xml' path='doc/member[@name="NONCLIENTMETRICSA.iCaptionHeight"]/*' />
    public int iCaptionHeight;

    /// <include file='NONCLIENTMETRICSA.xml' path='doc/member[@name="NONCLIENTMETRICSA.lfCaptionFont"]/*' />
    public LOGFONTA lfCaptionFont;

    /// <include file='NONCLIENTMETRICSA.xml' path='doc/member[@name="NONCLIENTMETRICSA.iSmCaptionWidth"]/*' />
    public int iSmCaptionWidth;

    /// <include file='NONCLIENTMETRICSA.xml' path='doc/member[@name="NONCLIENTMETRICSA.iSmCaptionHeight"]/*' />
    public int iSmCaptionHeight;

    /// <include file='NONCLIENTMETRICSA.xml' path='doc/member[@name="NONCLIENTMETRICSA.lfSmCaptionFont"]/*' />
    public LOGFONTA lfSmCaptionFont;

    /// <include file='NONCLIENTMETRICSA.xml' path='doc/member[@name="NONCLIENTMETRICSA.iMenuWidth"]/*' />
    public int iMenuWidth;

    /// <include file='NONCLIENTMETRICSA.xml' path='doc/member[@name="NONCLIENTMETRICSA.iMenuHeight"]/*' />
    public int iMenuHeight;

    /// <include file='NONCLIENTMETRICSA.xml' path='doc/member[@name="NONCLIENTMETRICSA.lfMenuFont"]/*' />
    public LOGFONTA lfMenuFont;

    /// <include file='NONCLIENTMETRICSA.xml' path='doc/member[@name="NONCLIENTMETRICSA.lfStatusFont"]/*' />
    public LOGFONTA lfStatusFont;

    /// <include file='NONCLIENTMETRICSA.xml' path='doc/member[@name="NONCLIENTMETRICSA.lfMessageFont"]/*' />
    public LOGFONTA lfMessageFont;

    /// <include file='NONCLIENTMETRICSA.xml' path='doc/member[@name="NONCLIENTMETRICSA.iPaddedBorderWidth"]/*' />
    public int iPaddedBorderWidth;
}
