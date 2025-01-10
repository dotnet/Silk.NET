// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct PRINTDLGW
{
    [NativeTypeName("DWORD")]
    public uint lStructSize;
    public HWND hwndOwner;
    public HGLOBAL hDevMode;
    public HGLOBAL hDevNames;
    public HDC hDC;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("WORD")]
    public ushort nFromPage;

    [NativeTypeName("WORD")]
    public ushort nToPage;

    [NativeTypeName("WORD")]
    public ushort nMinPage;

    [NativeTypeName("WORD")]
    public ushort nMaxPage;

    [NativeTypeName("WORD")]
    public ushort nCopies;
    public HINSTANCE hInstance;
    public LPARAM lCustData;

    [NativeTypeName("LPPRINTHOOKPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnPrintHook;

    [NativeTypeName("LPSETUPHOOKPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnSetupHook;

    [NativeTypeName("LPCWSTR")]
    public ushort* lpPrintTemplateName;

    [NativeTypeName("LPCWSTR")]
    public ushort* lpSetupTemplateName;
    public HGLOBAL hPrintTemplate;
    public HGLOBAL hSetupTemplate;
}
