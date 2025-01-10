// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct PRINTDLGEXW
{
    [NativeTypeName("DWORD")]
    public uint lStructSize;
    public HWND hwndOwner;
    public HGLOBAL hDevMode;
    public HGLOBAL hDevNames;
    public HDC hDC;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint Flags2;

    [NativeTypeName("DWORD")]
    public uint ExclusionFlags;

    [NativeTypeName("DWORD")]
    public uint nPageRanges;

    [NativeTypeName("DWORD")]
    public uint nMaxPageRanges;

    [NativeTypeName("LPPRINTPAGERANGE")]
    public PRINTPAGERANGE* lpPageRanges;

    [NativeTypeName("DWORD")]
    public uint nMinPage;

    [NativeTypeName("DWORD")]
    public uint nMaxPage;

    [NativeTypeName("DWORD")]
    public uint nCopies;
    public HINSTANCE hInstance;

    [NativeTypeName("LPCWSTR")]
    public ushort* lpPrintTemplateName;

    [NativeTypeName("LPUNKNOWN")]
    public IUnknown lpCallback;

    [NativeTypeName("DWORD")]
    public uint nPropertyPages;
    public HPROPSHEETPAGE* lphPropertyPages;

    [NativeTypeName("DWORD")]
    public uint nStartPage;

    [NativeTypeName("DWORD")]
    public uint dwResultAction;
}
