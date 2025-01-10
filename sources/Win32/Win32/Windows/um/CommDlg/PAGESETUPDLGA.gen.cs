// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct PAGESETUPDLGA
{
    [NativeTypeName("DWORD")]
    public uint lStructSize;
    public HWND hwndOwner;
    public HGLOBAL hDevMode;
    public HGLOBAL hDevNames;

    [NativeTypeName("DWORD")]
    public uint Flags;
    public POINT ptPaperSize;
    public RECT rtMinMargin;
    public RECT rtMargin;
    public HINSTANCE hInstance;
    public LPARAM lCustData;

    [NativeTypeName("LPPAGESETUPHOOK")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnPageSetupHook;

    [NativeTypeName("LPPAGEPAINTHOOK")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnPagePaintHook;

    [NativeTypeName("LPCSTR")]
    public sbyte* lpPageSetupTemplateName;
    public HGLOBAL hPageSetupTemplate;
}
