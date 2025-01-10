// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CHOOSEFONTA
{
    [NativeTypeName("DWORD")]
    public uint lStructSize;
    public HWND hwndOwner;
    public HDC hDC;

    [NativeTypeName("LPLOGFONTA")]
    public LOGFONTA* lpLogFont;
    public int iPointSize;

    [NativeTypeName("DWORD")]
    public uint Flags;
    public COLORREF rgbColors;
    public LPARAM lCustData;

    [NativeTypeName("LPCFHOOKPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnHook;

    [NativeTypeName("LPCSTR")]
    public sbyte* lpTemplateName;
    public HINSTANCE hInstance;

    [NativeTypeName("LPSTR")]
    public sbyte* lpszStyle;

    [NativeTypeName("WORD")]
    public ushort nFontType;

    [NativeTypeName("WORD")]
    public ushort ___MISSING_ALIGNMENT__;
    public int nSizeMin;
    public int nSizeMax;
}
