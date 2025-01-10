// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct NMTBCUSTOMDRAW
{
    public NMCUSTOMDRAW nmcd;
    public HBRUSH hbrMonoDither;
    public HBRUSH hbrLines;
    public HPEN hpenLines;
    public COLORREF clrText;
    public COLORREF clrMark;
    public COLORREF clrTextHighlight;
    public COLORREF clrBtnFace;
    public COLORREF clrBtnHighlight;
    public COLORREF clrHighlightHotTrack;
    public RECT rcText;
    public int nStringBkMode;
    public int nHLStringBkMode;
    public int iListGap;
}
