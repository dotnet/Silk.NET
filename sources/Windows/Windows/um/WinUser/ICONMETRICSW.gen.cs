// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ICONMETRICSW.xml' path='doc/member[@name="ICONMETRICSW"]/*'/>
public partial struct ICONMETRICSW
{
    /// <include file='ICONMETRICSW.xml' path='doc/member[@name="ICONMETRICSW.cbSize"]/*'/>
    public uint cbSize;
    /// <include file='ICONMETRICSW.xml' path='doc/member[@name="ICONMETRICSW.iHorzSpacing"]/*'/>
    public int iHorzSpacing;
    /// <include file='ICONMETRICSW.xml' path='doc/member[@name="ICONMETRICSW.iVertSpacing"]/*'/>
    public int iVertSpacing;
    /// <include file='ICONMETRICSW.xml' path='doc/member[@name="ICONMETRICSW.iTitleWrap"]/*'/>
    public int iTitleWrap;
    /// <include file='ICONMETRICSW.xml' path='doc/member[@name="ICONMETRICSW.lfFont"]/*'/>
    public LOGFONTW lfFont;
}