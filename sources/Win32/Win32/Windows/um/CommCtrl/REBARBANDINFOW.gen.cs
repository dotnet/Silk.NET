// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct REBARBANDINFOW
{
    public uint cbSize;
    public uint fMask;
    public uint fStyle;
    public COLORREF clrFore;
    public COLORREF clrBack;

    [NativeTypeName("LPWSTR")]
    public ushort* lpText;
    public uint cch;
    public int iImage;
    public HWND hwndChild;
    public uint cxMinChild;
    public uint cyMinChild;
    public uint cx;
    public HBITMAP hbmBack;
    public uint wID;
    public uint cyChild;
    public uint cyMaxChild;
    public uint cyIntegral;
    public uint cxIdeal;
    public LPARAM lParam;
    public uint cxHeader;
    public RECT rcChevronLocation;
    public uint uChevronState;
}
