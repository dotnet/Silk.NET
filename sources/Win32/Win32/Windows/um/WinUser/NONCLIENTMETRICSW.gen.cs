// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct NONCLIENTMETRICSW
{
    public uint cbSize;
    public int iBorderWidth;
    public int iScrollWidth;
    public int iScrollHeight;
    public int iCaptionWidth;
    public int iCaptionHeight;
    public LOGFONTW lfCaptionFont;
    public int iSmCaptionWidth;
    public int iSmCaptionHeight;
    public LOGFONTW lfSmCaptionFont;
    public int iMenuWidth;
    public int iMenuHeight;
    public LOGFONTW lfMenuFont;
    public LOGFONTW lfStatusFont;
    public LOGFONTW lfMessageFont;
    public int iPaddedBorderWidth;
}
