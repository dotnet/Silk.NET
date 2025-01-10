// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct OPENFILENAMEW
{
    [NativeTypeName("DWORD")]
    public uint lStructSize;
    public HWND hwndOwner;
    public HINSTANCE hInstance;

    [NativeTypeName("LPCWSTR")]
    public ushort* lpstrFilter;

    [NativeTypeName("LPWSTR")]
    public ushort* lpstrCustomFilter;

    [NativeTypeName("DWORD")]
    public uint nMaxCustFilter;

    [NativeTypeName("DWORD")]
    public uint nFilterIndex;

    [NativeTypeName("LPWSTR")]
    public ushort* lpstrFile;

    [NativeTypeName("DWORD")]
    public uint nMaxFile;

    [NativeTypeName("LPWSTR")]
    public ushort* lpstrFileTitle;

    [NativeTypeName("DWORD")]
    public uint nMaxFileTitle;

    [NativeTypeName("LPCWSTR")]
    public ushort* lpstrInitialDir;

    [NativeTypeName("LPCWSTR")]
    public ushort* lpstrTitle;

    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("WORD")]
    public ushort nFileOffset;

    [NativeTypeName("WORD")]
    public ushort nFileExtension;

    [NativeTypeName("LPCWSTR")]
    public ushort* lpstrDefExt;
    public LPARAM lCustData;

    [NativeTypeName("LPOFNHOOKPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nuint> lpfnHook;

    [NativeTypeName("LPCWSTR")]
    public ushort* lpTemplateName;
    public void* pvReserved;

    [NativeTypeName("DWORD")]
    public uint dwReserved;

    [NativeTypeName("DWORD")]
    public uint FlagsEx;
}
