// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct DTTOPTS
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("DWORD")]
    public uint dwFlags;
    public COLORREF crText;
    public COLORREF crBorder;
    public COLORREF crShadow;
    public int iTextShadowType;
    public POINT ptShadowOffset;
    public int iBorderSize;
    public int iFontPropId;
    public int iColorPropId;
    public int iStateId;
    public BOOL fApplyOverlay;
    public int iGlowSize;

    [NativeTypeName("DTT_CALLBACK_PROC")]
    public delegate* unmanaged<HDC, ushort*, int, RECT*, uint, LPARAM, int> pfnDrawTextCallback;
    public LPARAM lParam;
}
